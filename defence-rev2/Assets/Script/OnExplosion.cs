using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExplosion : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        //TODO: Check who i hit.
        col.gameObject.SendMessage("minusHealth", 2000f);

        Debug.Log("sent!");

    }
}
