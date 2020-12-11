using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnRate = 1f;

    void Start(){
    	Spawn();
    }
    void Spawn(){
    	Instantiate(obj[Random.Range(0,obj.Length)],transform.position,Quaternion.identity);
    	Invoke("Spawn",spawnRate);
    }
}
