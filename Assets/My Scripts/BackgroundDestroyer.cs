using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundDestroyer : MonoBehaviour
{
    public GameObject spawner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.tag == "Player")
    	{
    		SceneManager.LoadScene("SampleScene");
    	}
    }
    private void OnTriggerStay2D(Collider2D collision){
    	collision.gameObject.transform.position = spawner.transform.position;
    }
}
