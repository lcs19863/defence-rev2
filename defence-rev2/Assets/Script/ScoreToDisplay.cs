using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreToDisplay : MonoBehaviour {

    private GameObject scoreCounter;
    public Text scoreDisplay;
    private Score score;

    // Use this for initialization
    void Start () {
        scoreCounter = GameObject.FindGameObjectWithTag("ScoreDisplay");
        score = scoreCounter.GetComponent<Score>();
        scoreDisplay.text = "HighScore:" + score.score;
    }
	
}
