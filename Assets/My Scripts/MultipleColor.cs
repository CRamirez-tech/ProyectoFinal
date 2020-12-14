using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleColor : MonoBehaviour
{
    public Text[] texts;
    float aux;
    public float timeRemaining = 5;
    public Material[] colors;

    void Start()
    {
    	aux = timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        if (aux > 0)
        {
            aux -= Time.deltaTime;
        }else{
            int n = Random.Range(0, colors.Length);
            for(int i=0;i<texts.Length;i++){
                texts[i].material = colors[n];
            }
        	aux = timeRemaining;
        }
    }
}
