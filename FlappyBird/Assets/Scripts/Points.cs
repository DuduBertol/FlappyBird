using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Points : MonoBehaviour
{
    public GameManager gameManager;

    private void Start() 
    {
        gameManager = FindObjectOfType<GameManager>();    
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        gameManager.score++;        
        gameManager.scoreText.text = gameManager.score.ToString();
    }
}
