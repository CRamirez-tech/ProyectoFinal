using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVida : MonoBehaviour
{
    public GameObject CanvasObject;
    void Start()
    {
    	Destroy(gameObject,32);
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
    }
}
