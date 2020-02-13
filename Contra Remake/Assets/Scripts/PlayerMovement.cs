using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	public CharacterController2D controller;
    private Rigidbody2D rd2d;
    public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;

    private bool isGrounded;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () 
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		/*if (Input.GetKey(KeyCode.W))
		{
			jump = true;
		}*/
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
            if (Input.GetKey(KeyCode.W) && isGrounded == true)
            {
                rd2d.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);

                isGrounded = false;
            }
        }
    }

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}
}