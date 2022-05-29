using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject lPlayerPaddle, rPlayerPaddle;
    public GameObject leftWall, rightWall;
    public GameObject lPlayerText, rPlayerText;
    private int lPlayerScore, rPlayerScore = 0;
    public void LPlayerScored()
    {
        lPlayerScore++;
        lPlayerText.GetComponent<UnityEngine.UI.Text>().text = lPlayerScore.ToString();
        ball.GetComponent<Ball>().ResetPosition();
    }
    public void RPlayerScored()
    {
        rPlayerScore++;
        rPlayerText.GetComponent<UnityEngine.UI.Text>().text = rPlayerScore.ToString();
        ball.GetComponent<Ball>().ResetPosition();
    }
    


}
