
using System.Collections;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Movement parameters
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public bool grounded;  // To check if the player is on the ground
    public Transform groundCheck;    // Ground check reference
    public LayerMask groundLayer;     // Layer to specify ground objects


    // Components
    private Rigidbody2D rb;
    //private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MovePlayer();
        Jump();
    }

    // Handle player movement (left/right)
    void MovePlayer()
    {
        float moveInput = Input.GetAxis("Horizontal");

        // Apply movement
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

    }

    // Handle player jump
    public void Jump()
    {
        if (grounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
        
    
}

