using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float WalkSpeed = 3;
    public float RunSpeed = 5;
    public float JumpForce = 300;

    bool Running;
    bool Moving;
    bool Grounded;
    bool Falling;
    bool Building;

    Animator Animator;
    Rigidbody2D RigidBody2D;
    Vector2 gunPos;
    public Vector2 targetPos;

    void Start()
    {
        RigidBody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        gunPos = transform.GetChild(0).transform.position;
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Building = false;
        //Debug.DrawLine(new Vector3(1f,1f,1f), new Vector3(2f, 2f, 1f),Color.cyan);
    }

    void Update()
    {
        if (!Building)
        {
            MoveCharacter();
        }
        CheckFalling();
        CheckGrounded();

        // Update animator's variables
        Animator.SetBool("isRunning", Running);
        Animator.SetBool("isMoving", Moving);
        Animator.SetBool("isGrounded", Grounded);
        Animator.SetBool("isFalling", Falling);

    }



    void MoveCharacter()
    {
        Running = Input.GetButton("Run");

        // Determine movement speed
        float moveSpeed = Running ? RunSpeed : WalkSpeed;
        //Change value    (  IF   )    TRUE    :   FALSE   ;

        Moving = Input.GetButton("Horizontal");
        float direction = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(direction, 0, 0) * moveSpeed * Time.deltaTime;
        //transform.GetComponent<Rigidbody2D>().MovePosition(new Vector2(direction, 0));
        FaceDirection(new Vector2(direction, 0));

        if (Grounded && Input.GetButtonDown("Jump"))
        {
            RigidBody2D.AddForce(Vector2.up * JumpForce);
        }

    }

    void CheckFalling()
    {
        Falling = RigidBody2D.velocity.y < -0.1f;
    }

    void CheckGrounded()
    {
        Grounded = RigidBody2D.velocity.y == 0.0f;
    }

    void FaceDirection(Vector2 direction)
    {
        if (direction == Vector2.zero)  //Don't change look.
            return;

        // Flip the sprite (NOTE: Vector3.forward is positive Z in 3D. The Sprite is on XY plane!)
        Quaternion rotation3D = direction == Vector2.right ? Quaternion.LookRotation(Vector3.forward) : Quaternion.LookRotation(Vector3.back);
        transform.rotation = rotation3D;
    }

    void faceShootingDirection(Vector2 dir)
    {
        if (dir.x > 0)
        {
            FaceDirection(new Vector2(1,0));
        }
        else if (dir.x < 0)
        {
            FaceDirection(new Vector2(-1, 0));
        }
        else
        {

        }
    }

    public Vector2 GetFacingDirection()
    {
        //float direction = Input.GetAxisRaw("Horizontal");
        gunPos = transform.GetChild(0).transform.position;
        //targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 currentPos = transform.position;
        //Debug.Log("pos: "+currentPos+" gunPos: "+gunPos);
        Vector2 direction;
        if (gunPos.x>currentPos.x)
        {
            direction = new Vector2(1, 0);
        }
        else
        {
            direction = new Vector2(-1, 0);
        }
        Vector2 mFaceDirection = direction;
        return mFaceDirection;
    }

    public Vector2 shootDirection()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 diff = new Vector2(targetPos.x - transform.position.x,targetPos.y-transform.position.y);
        diff.Normalize();
        //Debug.Log(diff);

        float degreeRad = Mathf.Atan2(diff.y, diff.x);
        float degree = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        //Debug.Log(degree);

        Vector2 shootVec = new Vector2(Mathf.Cos(degreeRad),Mathf.Sin(degreeRad));
        //Debug.Log(degree+","+shootVec);
        return shootVec;
        //transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }

    void isBuilding(bool construct)
    {
        Building = construct;
    }
}
