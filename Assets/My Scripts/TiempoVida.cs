using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVida : MonoBehaviour
{
	public float tiempoVida;// de los objetos de los saltos
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject,tiempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
