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
    float coins = 0;
    float playerScore = 0;
    float moment;
    string message="";
    //ManageGame manager;
    // Update is called once per frame
    void Start(){
        //manager = GameObject.FindGameObjectWithTag("GameController").GetComponent(ManageGame);
    }
    void Update()
    {
        playerScore += Time.deltaTime;
        if(moment+0.5f<=playerScore){
            message = "";
        }
    }
    public void addCoins(int n){
        coins+=n;
    }
    public void removeLife(int n,GameObject player){
        setMessage("-Life");
        refreshImage(n*-1);
        if(lifes<1)
        {
            SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
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
        setMessage("+ "+amount*10);
    }
    public void setMessage(string str){
        moment = playerScore;
        message = str;
    }
    private void OnGUI()
    {
        scoreText.text = (int)(playerScore*10)+"";
        messageText.text = message;
        coinsText.text =(int)(coins)+"" ;
    }
}
