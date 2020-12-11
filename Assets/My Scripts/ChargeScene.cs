using System.Collections;	
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeScene : MonoBehaviour
{
	GameObject controller;
    public void backToMain(){
    	controller = GameObject.FindGameObjectWithTag("GameController");
    	Destroy(controller);
    	SceneManager.LoadScene("MainScene");
    }
    public void backToGame(){
    	SceneManager.LoadScene("Game");
    }
}
