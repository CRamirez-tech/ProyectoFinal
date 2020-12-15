using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent (typeof (AudioSource))]
public class ManageGame : MonoBehaviour
{
    
    public AudioClip[] musics;
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    public void changeMusic(int n){
    	if(n<musics.Length && n>=0){
    		m_MyAudioSource.Stop();
    		m_MyAudioSource.clip = musics[n];
    		m_MyAudioSource.Play();
    	}
    }
    public void LlamarNivel(string str){
    	SceneManager.LoadScene(str);
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
