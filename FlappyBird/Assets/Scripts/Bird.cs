using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rig;
    public GameObject gameOver;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
