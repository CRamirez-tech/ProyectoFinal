using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    HUDScript HUD;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision){
    	if(collision.tag == "Player")
    	{
    		HUD = GameObject.Find("Main Camera").GetComponent<HUDScript>();
    		HUD.increaseScore(1);
            HUD.addCoins(1);
    		Destroy(this.gameObject);
    	}
    }
}
