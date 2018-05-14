using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float mHealth = 1000f;
    public bool alive = true;
    private GameObject scoreCounter;
    private Score score;

	void Start () {
        scoreCounter = GameObject.FindGameObjectWithTag("ScoreDisplay");
        score = scoreCounter.GetComponent<Score>();
    }
	
	// Update is called once per frame
	void Update () {
        if (mHealth<0)
        {
            Die();
            //score.changeScore(40);
            scoreCounter.SendMessage("changeScore", 40);

        }
        if (alive) {
            Move();
        }
        if (transform.position.x > 13)
        {
            //score = scoreCounter.GetComponent<Score>();
            scoreCounter.SendMessage("changeScore",-100);
            //score.changeScore(-100);
            Die();
        }
    }

    void Move()
    {
        transform.position += new Vector3(0.5f, 0, 0) * 5 * Time.deltaTime;
    }
    
    void Die()
    {
        alive = false;
        Destroy(this.gameObject);
    }

    public void minusHealth(float bleed)
    {
        mHealth = mHealth - bleed;
    }
}
