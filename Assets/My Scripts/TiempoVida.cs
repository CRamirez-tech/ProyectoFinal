using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVida : MonoBehaviour
{
    public int tiempoVida;
    public GameObject CanvasObject;
    GameObject manager;
    //ManageGame manager;
    void Start()
    {
    	Destroy(gameObject,tiempoVida);
        manager = GameObject.Find("Manage Game");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        CanvasObject.SetActive(true);
        manager.GetComponent<AudioSource>().Play();
    }
}
