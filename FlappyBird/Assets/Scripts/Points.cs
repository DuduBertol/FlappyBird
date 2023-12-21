using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Points : MonoBehaviour
{
    public GameController gameController;

    private void Start() 
    {
        gameController = FindObjectOfType<GameController>();    
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        gameController.score++;        
        gameController.scoreText.text = gameController.score.ToString();
    }
}
