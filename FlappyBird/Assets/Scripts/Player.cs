using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    
    private Rigidbody2D rig;
    private GameManager gameManager;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        rig.gravityScale = gameManager.gravity;

        if(Input.GetMouseButtonDown(0) && gameManager.isGameStarted && !gameManager.isGameOver)
        {
            rig.velocity = Vector2.up * jumpForce;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.layer == 6)
        {
            gameManager.isGameOver = true;
            gameManager.gameOverPanel.SetActive(true);
        }
        
        //Time.timeScale = 0;
    }
}
