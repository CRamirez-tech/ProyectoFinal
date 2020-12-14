using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextColor : MonoBehaviour
{
    Text text;
    float aux;
    public float timeRemaining = 5;
    public Material[] colors;

    void Start()
    {
    	text = GetComponent<Text>();
    	aux = timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        if (aux > 0)
        {
            aux -= Time.deltaTime;
        }else{
        	text.material = colors[Random.Range(0, colors.Length)];
        	aux = timeRemaining;
        }
    }
}
