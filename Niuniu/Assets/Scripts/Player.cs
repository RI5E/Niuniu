using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {
    public float maxSpeed = 1;
    public float speed = 10f;
    public float jumpPower = 150f;

    public bool grounded;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce((Vector2.right * speed) * h);

        if (Math.Abs(rb2d.velocity.x) > maxSpeed)
        {
            float sign = 1;
            if (rb2d.velocity.x < 0)
            {
                sign = -1;
            }
            rb2d.velocity = new Vector2(maxSpeed * sign, rb2d.velocity.y);
        }

        float y = Input.GetAxis("Vertical");
    }
}
