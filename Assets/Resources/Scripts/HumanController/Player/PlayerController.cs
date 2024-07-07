using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : HumanMovement
{
    public Rigidbody2D rigidBody;
    public float moveSpeed = 5f;
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rigidBody = this.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }
    override public void Move()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        // 플레이어 좌우 이동
        rigidBody.velocity = new Vector2(horizontalInput * moveSpeed, rigidBody.velocity.y);
        // 플레이어가 좌우로 이동하는 방향을 바라보도록 설정
        if (horizontalInput != 0f)
        {
            animator.SetBool("isWalk_Left", true);
            transform.localScale = new Vector3(Mathf.Sign(horizontalInput), 1f, 1f);
        }
        else
        {
            animator.SetBool("isWalk_Left", false);
        }

    }
}
