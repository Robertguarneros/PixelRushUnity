using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveKart : MonoBehaviour
{
    public float velocity;
    public float jumpingStrength;
    private Rigidbody2D rigidBody;
    private CapsuleCollider2D boxCollider;

    private float coyoteTime = 0.2f;
    private float coyoteTimeCounter;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * 0.9f, Color.red);

        if (IsGrounded())
        {
            coyoteTimeCounter = coyoteTime;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }

        ProcessMovement();
        ProcessJump();
    }

    void ProcessJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coyoteTimeCounter > 0f)
            {
                rigidBody.AddForce(Vector2.up * jumpingStrength, ForceMode2D.Impulse);
                coyoteTimeCounter = 0f;
            }
        }
    }

    void ProcessMovement()
    {
        float inputMovement = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(inputMovement * velocity, rigidBody.velocity.y);
    }

    bool IsGrounded()
    {
        // Adjust the parameters based on your character's collider and the ground
        return Physics2D.Raycast(transform.position, Vector3.down, 0.9f);
    }
}
