using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playerwalk : MonoBehaviour
{
    //Player Move
    private float horizontal;
    [SerializeField] float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    bool facingRight = true;
    private Vector2 playerMove;

    //Player Jump
    private float jumpPower = 5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    //Player animator
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);

        horizontal = Input.GetAxisRaw("Horizontal");

        anim.SetFloat("XInput", Mathf.Abs(horizontal));
        anim.SetBool("IsWalking", Mathf.Abs(horizontal) > 0);


        if (horizontal < 0)
        {
            facingRight = false;
        }
        else if (horizontal > 0)
        {
            facingRight = true;
        }

        anim.SetBool("FaceingRight", facingRight);

        if (Input.GetKey("w") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        //if (Input.GetKey("w"))
        //{
        //Jump animation
        //}

    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

}