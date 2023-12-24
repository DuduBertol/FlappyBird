using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float maxHeight;
    public float minHeight;
    public float maxTime;
    public float timer;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
    }

    void Update()
    {
        if(gameManager.isGameStarted && !gameManager.isGameOver)
        {
            timer += Time.deltaTime;
        }

        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            Destroy(newPipe, 7f);
            timer = 0f;
        }
    }
}
