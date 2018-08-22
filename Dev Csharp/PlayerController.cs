using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float speed;
    public float jumpForce;
    public float secondJumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJump;
    public int extraJumpValue;
    
    //Dash tentative
    public float startDashTime;
    float dashTime;
    public float dashSpeed;
    int dashDir = 0;
    bool isDashing = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        extraJump = extraJumpValue;
        dashTime = startDashTime;
	}


    private void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);




        if (Input.GetButton("Dash"))
        {

            Dash();

        }



        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }


        

    }

    // Update is called once per frame
    void Update ()
    {

        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }

        Jump();
        
        /*
         * "Blink" system, used while dash does not work
         * if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.position += new Vector3(dashSpeed * Time.deltaTime, 0.1f,0f);
        }
        */
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && extraJump > 0)
        {
            rb.velocity = Vector2.up * secondJumpForce;
            extraJump--;
        }
        if (Input.GetButtonDown("Jump") && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void Dash()
    {
        /*if(Input.GetButton("Dash") && moveInput > 0) ESSE AQUI AINDA FUNFA QLQR COISA
        {
            rb.velocity = transform.right * dashSpeed;
        }
        else if(Input.GetButton("Dash") && moveInput < 0)
        {
            rb.velocity = -transform.right * dashSpeed;
        }*/
        Debug.Log(dashTime);
        Debug.Log(isDashing);
        isDashing = true;
        if (transform.localScale.x > 0 && isDashing == true && dashTime > 0)
        {
            dashTime -= Time.deltaTime;
            rb.velocity = transform.right * dashSpeed;
        }
        else if (transform.localScale.x < 0 && isDashing == true && dashTime > 0)
        {
            dashTime -= Time.deltaTime;
            rb.velocity = -transform.right * dashSpeed;
        }
        
        
    }
}
