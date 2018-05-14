using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Build : MonoBehaviour {

    GameObject thePlayer;
    PlayerScript mPlayer;
    Shoot mShoot;
    GameObject structure;
    //Vector2 placementPoint;
    Vector2 targetPos;
    Animator mAnimator;

    //public bool isBuilding;
    bool hasBuilt;

    public GameObject mPrefab;
    //public Texture BoxTexture;

    void Start () {
        //isBuilding = false;
        hasBuilt = false;
        thePlayer = GameObject.Find("Player");
        mPlayer = thePlayer.GetComponent<PlayerScript>(); ;
        mShoot = thePlayer.GetComponentInChildren<Shoot>();
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
	
	// Update is called once per frame
	void Update () {
        float toBuild = Input.GetAxisRaw("Build");
        if (toBuild==1 && !hasBuilt)
        {
            structure = Instantiate(mPrefab, new Vector3(targetPos.x,targetPos.y, 0f), Quaternion.identity);
            mAnimator = structure.GetComponent<Animator>();
            mAnimator.enabled = false;
            buildStructureLoc();
            hasBuilt = true;
            mPlayer.SendMessage("isBuilding",true);
            mShoot.SendMessage("isBuilding", true);
            //isBuilding = true;
        }
        else if (toBuild == 0)
        {
            Destroy(structure);
            //isBuilding = false;
            if (hasBuilt)
            {
                Instantiate(mPrefab, new Vector3(targetPos.x, targetPos.y, 0f), Quaternion.identity);
            }
            hasBuilt = false;
            //isBuilding = false;
            mPlayer.SendMessage("isBuilding", false);
            mShoot.SendMessage("isBuilding", false);
        }
        else if (toBuild == 1)
        {
            buildStructureLoc();
            //isBuilding = true;
        }
        
	}

    void buildStructureLoc()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float placementTestUx = structure.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().transform.position.x - structure.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        float placementTestUy = structure.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().transform.position.y + structure.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        float placementTestDx = structure.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().transform.position.x + structure.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        float placementTestDy = structure.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().transform.position.y - structure.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        Vector2 placementTestU = new Vector2(placementTestUx, placementTestUy);
        Vector2 placementTestD = new Vector2(placementTestDx, placementTestDy);
        structure.GetComponent<Rigidbody2D>().isKinematic = true;
        structure.GetComponent<BoxCollider2D>().enabled = false;
        structure.GetComponent<Transform>().position = new Vector3(targetPos.x,targetPos.y, 0f);
        float pointAx = structure.GetComponent<BoxCollider2D>().transform.position.x - structure.GetComponent<SpriteRenderer>().bounds.size.x/2;
        float pointAy = structure.GetComponent<BoxCollider2D>().transform.position.y + structure.GetComponent<SpriteRenderer>().bounds.size.y/2;
        float pointBx = structure.GetComponent<BoxCollider2D>().transform.position.x + structure.GetComponent<SpriteRenderer>().bounds.size.x/2;
        float pointBy = structure.GetComponent<BoxCollider2D>().transform.position.y - structure.GetComponent<SpriteRenderer>().bounds.size.y/2;
        float sizeX = structure.GetComponent<SpriteRenderer>().bounds.size.x;
        float sizeY = structure.GetComponent<SpriteRenderer>().bounds.size.y;
        Vector2 pointA = new Vector2(pointAx,pointAy);
        Vector2 pointB = new Vector2(pointBx, pointBy);
        //EditorGUI.DrawRect(new Rect(pointAx,pointAy, sizeX, sizeY), Color.green);
        //OnGUI(pointAx, pointAy, sizeX, sizeY);
        //Debug.Log("center:"+new Vector2(structure.GetComponent<BoxCollider2D>().transform.position.x, structure.GetComponent<BoxCollider2D>().transform.position.y) +" size:"+new Vector2(structure.GetComponent<SpriteRenderer>().bounds.size.x, structure.GetComponent<SpriteRenderer>().bounds.size.y) +" start:"+pointA+" end:"+pointB);
        Debug.DrawLine(new Vector3(pointA.x, pointA.y,1f),new Vector3(pointB.x, pointB.y, 1f),Color.blue,2f);
        //Debug.Log(pointA);
        //Debug.DrawLine(new Vector3(structure.GetComponent<BoxCollider2D>().transform.position.x, structure.GetComponent<BoxCollider2D>().transform.position.y,1f),new Vector3(structure.GetComponent<BoxCollider2D>().transform.position.x, structure.GetComponent<BoxCollider2D>().transform.position.y, 1f),Color.magenta,2f);
        //Debug.DrawLine(new Vector3(1f,1f,1f),new Vector3(1f, 1f, 1f),Color.black,2f);
        Debug.DrawLine(new Vector3(placementTestU.x, placementTestU.y, 1f), new Vector3(placementTestD.x, placementTestD.y, 1f), Color.red, 2f);
        //Physics2D.IgnoreLayerCollision(9,10,true);
        Physics2D.IgnoreLayerCollision(10, 11, true);
        Collider2D cd = Physics2D.OverlapArea(pointA, pointB);
        Collider2D pp = Physics2D.OverlapArea(placementTestU, placementTestD);
        //Physics2D.IgnoreCollision(cd,pp,true);
        if(!cd && pp)
        {
            structure.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 0.7f);
            Debug.Log("Canbe!Collided with:" + pp.GetComponent<Collider2D>().name);
        }
        else if (cd) {
            structure.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f, 0.7f);
            Debug.Log("Cannot!Collided with:" + cd.GetComponent<Collider2D>().name);
        }
        else
        {
            structure.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 1f, 0.7f);
            Debug.Log("Nocan!");
        }
    }

    /*void OnGUI(float a,float b,float c,float d)
    {
        GUI.Box(new Rect(a, b, c, d), BoxTexture);
    }*/
}
