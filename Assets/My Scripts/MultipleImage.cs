using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleImage : MonoBehaviour
{
    float aux;
    public float timeRemaining = 5;
    public Material[] colors;
    public Image[] images;
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
            for(int i=0;i<images.Length;i++){
                images[i].material = colors[n];
            }
        	aux = timeRemaining;
        }
    }
}
