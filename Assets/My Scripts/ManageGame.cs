using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent (typeof (AudioSource))]
public class ManageGame : MonoBehaviour
{
    public AudioClip[] musics;
    public AudioClip[] sounds;
    int actual;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void changeMusic(int n){
    	if(n<musics.Length && n>=0){
    		audioSource.Stop();
    		audioSource.clip = musics[n];
    		audioSource.Play();
    	}
    }
    public void playSound(int n){
        audioSource.PlayOneShot(sounds[n], 0.7f);
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
    void Awake(){
    	DontDestroyOnLoad(this.gameObject);
    }
	
}
