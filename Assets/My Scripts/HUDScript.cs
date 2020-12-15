using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDScript : MonoBehaviour
{
    public Text scoreText;
    public Text messageText;
    public Text coinsText;
    public int lifes=6;
    public GameObject platform;
    public Sprite[] sprites;
    public Image imagen;
    int coins = 0;
    int playerScore = 0;
    float moment;
    string message="";
    int n=0;
    void FixedUpdate()
    {
        n++;
        if(n==20){
            n=0;
            playerScore+=2;
            message = "";
            scoreText.text = playerScore+"";
            messageText.text = message;
        }
        
        coinsText.text = coins+"" ;
    }
    public void addCoins(int n){
        coins+=n;
    }
    public void removeLife(int n,GameObject player){
        setMessage("-Life");
        refreshImage(n*-1);
        if(lifes<1)
        {
            SceneManager.LoadScene("GameOver");
        }
        player.transform.position = new Vector3(-3f,-1f,5f);
        Instantiate(platform,new Vector3(-1.5f,-3.5f,5f),Quaternion.identity);
    }
    public void addLife(int n){
        setMessage("+Life");
        if(lifes+n>6)
        {
            lifes = 6;
            n = 0;
        }
        refreshImage(n);
    }
    public void refreshImage(int n){
        lifes+=n;
        imagen.sprite = sprites[lifes];
    }
    public void increaseScore(int amount)
    {
    	playerScore += amount;
        setMessage("+ "+amount);
    }
    public void setMessage(string str){
        message = str;
    }
}
