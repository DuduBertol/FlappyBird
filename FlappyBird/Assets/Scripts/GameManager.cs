using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject skinPanel;
    
    public GameObject gameOverPanel;


    public int score;
    public TMP_Text scoreText;
    public float gravity;
    
    public bool isGameStarted;
    public bool isGameOver;

    

    private void Start() 
    {
        //Time.timeScale = 1;
    }

    private void Update() 
    {
        //PANEL CONTROL
        if(isGameOver)
        {
            gameOverPanel.SetActive(true);
        }
    }

// BUTTONS -------------------------
    public void StartGame()
    {
        startPanel.SetActive(false);
        isGameStarted = true;
        gravity = 2f;
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void SkinPanel()
    {
        skinPanel.SetActive(true);
    }

    public void ReturnSkinPanel()
    {
        skinPanel.SetActive(false);
    }

#region DESABILITADO
    //POR HORA, DESABILITADO
    //public bool isGamePaused;
    //[SerializeField] GameObject pausePanel;

    /* public void Pause()
    {
        gravity = 0f;
        isGamePaused = true;
        pausePanel.SetActive(true);
    }
    public void Resume()
    {
        gravity = 2f;
        isGamePaused = false;
        pausePanel.SetActive(false);
    }
*/
#endregion
    
}
