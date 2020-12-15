using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVida : MonoBehaviour
{
    public static bool video = false;

    public int tiempoVida;
    public GameObject CanvasObject;
    
    void Start()
    {
    	Destroy(gameObject,tiempoVida);
        if(video){
            Destroy(gameObject);
        }
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
        video = true;
        CanvasObject.SetActive(true);
        AudioManager._instance.audioSource.Play();
    }
}
