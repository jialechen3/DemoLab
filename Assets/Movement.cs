using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] const int SPEED = 10;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] bool jumpPressed = false;
    [SerializeField] float jumpForce = 300.0f;
    [SerializeField] bool isGrounded = true;

    [SerializeField] Animator animator;

    const int IDLE = 0;
    const int RUN = 1;
    const int JUMP = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
        if (animator == null)
            animator = GetComponent<Animator>();
        //animator.SetInteger("motion", IDLE);
        
    }

    // Update is called once per frame --used for user input
    //do NOT use for physics & movement
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump")) {
            jumpPressed = true;
            
        }
            

    }

    //called potentially many times per frame
    //use for physics & movement
    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(SPEED * movement, rigid.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();
        if (jumpPressed && isGrounded) {
            Jump();
        }
            
        else
        { 
            jumpPressed = false;
            
            if (isGrounded)
            {
                if (movement > 0 || movement < 0)
                {
                    animator.SetFloat("Speed", 1);
                }
                else
                {
                    animator.SetFloat("Speed", movement);
                }
            }
            
        }

        
    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    private void Jump()
    {
        animator.SetBool("Jumping", true);
        rigid.velocity = new Vector2(rigid.velocity.x, 0);
        rigid.AddForce(new Vector2(0, jumpForce));
        //Debug.Log("jumped");
        jumpPressed = false;
        isGrounded = false;
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Stone") {
                isGrounded = true;
                animator.SetBool("Jumping", false);

        }
            
        // else
        //   Debug.Log(collision.gameObject.tag);
        animator.SetFloat("Speed", 0);
    }
}
