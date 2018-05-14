using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {

    public int score = 3000;
    public Text scoreDisplay;
    bool loaded = false;

    /*void Awake()
    {
        
    }*/

        // Use this for initialization
        void Start () {
        if (!loaded)
        {
            scoreDisplay.text = "Score:" + score;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (!loaded)
        {
            scoreDisplay.text = "Score:" + score;
            if (score > 3200 || score <= 0)
            {
                loadScore();
            }
        }
    }

    public void changeScore(int i)
    {
        score = score + i;
    }

    public void loadScore()
    {
        DontDestroyOnLoad(transform.gameObject);
        loaded = true;
        SceneManager.LoadScene("thescore");
        
    }
}
