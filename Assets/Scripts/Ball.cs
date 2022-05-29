using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ballRigidBody;
    public float speed = 15;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        float x;
        float y;
        ballRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        float randomNumber = Random.Range(0, 2);
        if(randomNumber == 0)
        {
            x = -1;
            randomNumber = Random.Range(0, 2);
        } else
        {
            x = 1;
            randomNumber = Random.Range(0, 2);
        }
        if (randomNumber == 0)
        {
            y = -1;
            
        }
        else
        {
            y = 1;
            
        }

        //float x = Random.Range(0, 2) == 0 ? -1 : 1;
        //float y = Random.Range(0, 2) == 0 ? -1 : 1;
        ballRigidBody.velocity = new Vector2(x * speed, y * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetPosition()
    {
        transform.position = startPos;
    }
}
