using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Movement : MonoBehaviour

{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    public float moveSpeed = 5f;
    bool isMoving = false;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer= GetComponent<SpriteRenderer>();
    }

    void Sprint()
    {
        if (Input.GetButtonDown("Sprint"))
        {
            moveSpeed = 10f;
        }
        if (Input.GetButtonUp("Sprint"))
        {
            moveSpeed = 5f;
        }
    }

    
    void Update()
    {
       float moveInputX = Input.GetAxisRaw("Horizontal");
       float moveInputY = Input.GetAxisRaw("Vertical");

       animator.SetFloat("Input X", moveInputX);
       animator.SetFloat("Input Y", moveInputY);

       Vector2 moveDirection = new Vector2(moveInputX, moveInputY);
       moveDirection.Normalize();
       
       rb2d.velocity = moveDirection * moveSpeed; 

       if (rb2d.velocity.magnitude > 0.1f)
       {
        isMoving = true;
       }
       else
       {
        isMoving = false;
       }
       animator.SetBool("IsMoving", isMoving);

       if(rb2d.velocity.x > 0)
       {
        spriteRenderer.flipX = false;
       }
       else if (rb2d.velocity.x < 0)
       {
        spriteRenderer.flipX = true;
       }

       Sprint();
    }
}
