using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence;
using Coherence.Toolkit;

public class GameManager : MonoBehaviour
{
    public Player player1, player2;
    public Goal goal1, goal2;
    public int scoreLimit;
    private int score1, score2;

    // Start is called before the first frame update
    void Start()
    {
        //player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        goal1 = GameObject.Find("Goal1").GetComponent<Goal>();
        goal2 = GameObject.Find("Goal2").GetComponent<Goal>();
    }

    // Update is called once per frame
    void Update()
    {
        score1 = goal1.score;
        score2 = goal2.score;

        //write checker based on grabbed object
        if (score1 >= scoreLimit)
        {
            //player at goal 1 wins
        }
        else if (score2 >= scoreLimit)
        { 
            //player at goal 2 wins
        }
    }
}
