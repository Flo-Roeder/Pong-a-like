using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject ball, player1, player2;
    [SerializeField] TextMeshProUGUI scoreP1TMP, scoreP2TMP;
    private int scoreP1, scoreP2;

    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Ball>().LaunchBall();
        scoreP1 = 0; 
        scoreP2 = 0;
        ScoreUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Goal(bool isPGoal1)
    {
        ball.GetComponent<Ball>().LaunchBall();
        if (isPGoal1)
        {
            scoreP2++;
        }
        else 
        {
            scoreP1++;
        }
        ScoreUpdate();
    }

    private void ScoreUpdate()
    {
        scoreP1TMP.text = scoreP1.ToString();
        scoreP2TMP.text = scoreP2.ToString();
    }

}
