using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artillery : MonoBehaviour {

    GameObject thePlayer;
    PlayerScript mPlayer;
    Shoot mShoot;

    Vector2 targetPos;
    GameObject structure;

    public GameObject mPrefab;
    public GameObject mShell;

    bool hasFired;
    bool isThere;

    void Start () {
        isThere = false;
        thePlayer = GameObject.Find("Player");
        mPlayer = thePlayer.GetComponent<PlayerScript>(); ;
        mShoot = thePlayer.GetComponentInChildren<Shoot>();
    }

	void Update () {
        float toFire = Input.GetAxisRaw("Barrage");
        if (toFire == 1 && !isThere)
        {
            structure = Instantiate(mPrefab, new Vector3(targetPos.x, -3.1f, 0f), Quaternion.identity);
            FireSupportLoc();
            isThere = true;
            mPlayer.SendMessage("isBuilding", true);
            mShoot.SendMessage("isBuilding", true);

            //isBuilding = true;
        }
        else if (toFire == 0)
        {
            Destroy(structure);
            //isBuilding = false;
            isThere = false;
            //isBuilding = false;
            mPlayer.SendMessage("isBuilding", false);
            mShoot.SendMessage("isBuilding", false);
        }
        else if (toFire == 1)
        {
            FireSupportLoc();
            //isBuilding = true;
            if (Input.GetButtonDown("Fire")) {
                isThere = false;
                spawnExplosive(targetPos);
                Destroy(structure);
                toFire = 0;
            }
        }
    }


    void FireSupportLoc()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        structure.GetComponent<Transform>().position = new Vector3(targetPos.x, -3.1f, 0f);
        structure.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 0.7f);
    }

    Vector3 confirm(bool up)
    {
        Vector3 coord = new Vector3(targetPos.x, -3.1f, 0f);
        if (up)
        {
            coord.y = 7f;
            return coord;
        }
        else
        {
            return coord;
        }
    }

    void spawnExplosive(Vector3 Loc)
    {
        float theX = Random.Range(1.5f+Loc.x,Loc.x-1.5f);
        Loc.x = theX;
        Loc.y = 7;
        GameObject shell = Instantiate(mShell, Loc, Quaternion.identity);
        Destroy(shell, 3.0f);
    }
}
