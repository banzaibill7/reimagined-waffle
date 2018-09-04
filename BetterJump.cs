using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {


    public float fallMult;
    public float lowJumpMult;

    Rigidbody2D rb;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(rb.velocity.y < 0)
        {
            rb.gravityScale = fallMult;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.gravityScale = lowJumpMult;
        }
        else
        {
            rb.gravityScale = 1f;
        }
	}
}
