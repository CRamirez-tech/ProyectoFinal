using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUpScript : MonoBehaviour
{
    HUDScript HUD;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision){
    	if(collision.tag == "Player")
    	{
    		HUD = GameObject.Find("Main Camera").GetComponent<HUDScript>();
    		HUD.increaseScore(2);
            HUD.addLife(1);
    		Destroy(this.gameObject);
    	}
    }
}
