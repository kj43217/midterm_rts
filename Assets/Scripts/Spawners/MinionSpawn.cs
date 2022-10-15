using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawn : MonoBehaviour
{
    [Header("Minions Prefabs")]
    [SerializeField] private GameObject[] minions;

    public float swarmerInterval = 3.5f;


    private IEnumerator spawnMinion(float intreval, GameObject minion){
        yield return new WaitForSeconds(intreval);
        GameObject newMinion = Instantiate(minion, new Vector3((8f), (3f), 0), Quaternion.identity);
        //StartCoroutine(spawnMinion(intreval, minion)); ---------------------/To spawn infinite minions
    }

    private void Start() {
        //only test
        StartCoroutine(spawnMinion(swarmerInterval,minions[0]));
    }
}
