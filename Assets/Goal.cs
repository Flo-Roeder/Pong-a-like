using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private Game game;
    [SerializeField] bool isGoal1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        game.Goal(isGoal1);
    }

}
