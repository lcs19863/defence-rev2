using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public GameObject explosion;

	void Start () {
		
	}
	
	void Update () {

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explode = Instantiate(explosion, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        Destroy(explode, 1.0f);
    }
}
