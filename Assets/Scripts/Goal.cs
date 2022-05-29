using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool leftWall;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (leftWall)
        {
            // Player R Scores
            GameObject.Find("GameManager").GetComponent<GameManager>().RPlayerScored();
        }
        else
        {
            // Player L Scores
            GameObject.Find("GameManager").GetComponent<GameManager>().LPlayerScored();
        }
    }
}
