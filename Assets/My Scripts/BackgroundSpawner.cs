using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnRate = 10f;

    void Start(){
    	for (int i = 0; i < obj.Length; i++)
        {
            Instantiate(obj[Random.Range(0,obj.Length)],transform.position + new Vector3(spawnRate*i,0,0),Quaternion.identity);
        }
    }
}
