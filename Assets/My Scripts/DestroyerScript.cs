using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision){
    	if(collision.tag == "Player")
    	{
    		Debug.Break();
    		return;
    	}
    	if(collision.gameObject.transform.parent)
    	{
    		Destroy(collision.gameObject.transform.parent.gameObject);
    	}
    	else
    	{
    		Destroy(collision.gameObject);
    	}
    }
}
