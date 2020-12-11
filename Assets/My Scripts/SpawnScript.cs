using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;
    private float aux;

    void Start(){
    	Spawn();
    }
    void Spawn(){
    	Instantiate(obj[Random.Range(0,obj.Length)],transform.position,Quaternion.identity);
        if(spawnMin<0){
            aux = spawnMax;
        }
        else{
            aux = Random.Range(spawnMin,spawnMax);
        }
    	Invoke("Spawn",aux);
    }
}
