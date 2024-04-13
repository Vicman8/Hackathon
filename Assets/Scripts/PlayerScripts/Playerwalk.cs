using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerwalk : MonoBehaviour
{
    //Player Move
    private float horizontal;
    [SerializeField] float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    bool facingRight = true;

    //Player Jump
    private float jumpPower = 5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal < 0 && facingRight)
        {
            Flip();
        }
        else if(horizontal > 0 && !facingRight)
        {
            Flip();
        }


        if(Input.GetKey("w") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        //if (Input.GetKey("w"))
        //{
            //Jump animation
        //}

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

}
