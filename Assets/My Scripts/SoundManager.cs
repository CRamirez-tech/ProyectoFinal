using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public AudioClip[] sounds;
    // Update is called once per frame
    public void playSound(int n)
    {
    	AudioManager._instance.audioSource.PlayOneShot(sounds[n], 0.6F);    
    }
}
