using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 5f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
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

       Vector2 moveDirection = new Vector2(moveInputX, moveInputY);
       moveDirection.Normalize();
       
       rb2d.velocity = moveDirection * moveSpeed; 

       Sprint();
    }
}
