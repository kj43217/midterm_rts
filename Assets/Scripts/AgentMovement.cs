using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{

    private Vector3 target;
    NavMeshAgent agent;

    [SerializeField]
    private float rotationSpeed;

    public Attack attack;

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetTargetPosition();
        SetAgentPosition();


    }

    void SetTargetPosition()
    {
        if (Input.GetMouseButtonDown(1))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
    }

    void SetAgentPosition()
    {
        agent.SetDestination(new Vector3(target.x, target.y, transform.position.z));
        if (attack.inCombat == false)
        {
            Vector3 Look = transform.InverseTransformPoint(target);
            float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg - 90;

            transform.Rotate(0, 0, Angle);

        }
        
    }
}
