using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject ScoreObject = null;
    public GameObject PlayersObject = null;
    
    private Text scoreText;
    private Text playersText;
    private int score;
    private int players;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        players = 3;
        scoreText = ScoreObject.GetComponent<Text> ();
        playersText = PlayersObject.GetComponent<Text> ();
        drawInfo();
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = score.ToString();
    }

    public void ScoreUp(int val){
        score += val;
        drawInfo();
    }

    public void LessPlayers(){
        players --;
        drawInfo();
    }

    private void drawInfo(){
        scoreText.text = $"Score {score.ToString()}";
        playersText.text = $"Player {players.ToString()}";
    }
}
