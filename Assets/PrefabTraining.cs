using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTraining : MonoBehaviour
{
    public bool spawn;
    private GameObject TargetPrefab;

    void Start()
    {
        spawn = true;
        TargetPrefab=Resources.Load<GameObject>("TrainingTarget");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-15.0f,15.0f),3.5f,10f);


        if (spawn == true){
            Instantiate(TargetPrefab,spawnLocation,Quaternion.identity);
            spawn = false;
        }
    }
}
