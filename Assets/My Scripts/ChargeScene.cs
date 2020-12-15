using System.Collections;	
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeScene : MonoBehaviour
{
    public void backToMain(){
        AudioManager._instance.changeMusic(0);
    	SceneManager.LoadScene("MainScene");
    }
    public void backToGame(){
    	AudioManager._instance.changeMusic(1);
    	SceneManager.LoadScene("Game");
    }
    public void LlamarNivel(string sc){
    	SceneManager.LoadScene(sc);
    }
    public void quitGame(){
        //Salir del editor de unity
    	Debug.Break();
        //Salir del juego en produccion
    	Application.Quit();
    }
}
