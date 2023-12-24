using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    private GameManager gameManager;
    public float speed;

    private void Start() 
    {
        gameManager = FindObjectOfType<GameManager>();    
    }

    private void Update() 
    {
        if(gameManager.isGameStarted && !gameManager.isGameOver)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
