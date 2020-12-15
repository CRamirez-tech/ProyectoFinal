using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent (typeof (AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager _instance;
    
    public AudioClip[] musics;
    public AudioSource audioSource;

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
    void Awake(){
        if (_instance == null){
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this);
        }
    }
	
}
