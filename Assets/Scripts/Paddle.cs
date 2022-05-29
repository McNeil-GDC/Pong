using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D paddleRigidbody;
    public bool isLeftPaddle;
    public float movement;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        paddleRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isLeftPaddle)
        {
            movement = Input.GetAxisRaw("LeftPaddleVertical");
        } else
        {
            movement = Input.GetAxisRaw("RightPaddleVertical");
        }
    }
    void FixedUpdate()
    {
        paddleRigidbody.velocity = new Vector2(paddleRigidbody.velocity.x, movement * speed);        
    }
}
