using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    Animator mAnimator;
    bool mShooting;
    bool Building;

    float kShootDuration = 0.25f;
    float mTime;

    public GameObject mBulletPrefab;
    PlayerScript mPlayer;

    void Start()
    {
        mAnimator = transform.parent.GetComponent<Animator>();

        mPlayer = transform.parent.GetComponent<PlayerScript>();

        Building = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire") && !Building)
        {

            shoot();

            mShooting = true;
            mTime = 0.0f;
        }

        if (mShooting)
        {
            mTime += Time.deltaTime;
            if (mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

        //UpdateAnimator();
    }

    void shoot()
    {
        if (checkPositive(mPlayer.GetFacingDirection().x) != checkPositive(mPlayer.shootDirection().x))
        {
            mPlayer.SendMessage("faceShootingDirection", mPlayer.shootDirection());
        }

        GameObject bulletObject = Instantiate(mBulletPrefab, transform.position, Quaternion.identity);
        Bullet bulletScript = bulletObject.GetComponent<Bullet>();

        
        bulletScript.SetDirection(mPlayer.shootDirection());
        Destroy(bulletObject, 2.0f);
    }

    private void UpdateAnimator()
    {
        mAnimator.SetBool("isShooting", mShooting);
    }

    int checkPositive(float num)
    {
        if (num >= 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    void isBuilding(bool construct)
    {
        Building = construct;
    }
}
