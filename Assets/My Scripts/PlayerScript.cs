using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    HUDScript HUD;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            HUD = GameObject.FindWithTag("HudManager").GetComponent<HUDScript>();
            HUD.removeLife(1,collision.gameObject);
        }
    }
    
    /*private void OnTriggerStay2D(Collider2D collision){
        if(collision.tag == "Player")
        {
            Debug.Break();
            return;
        }
    }*/
}
