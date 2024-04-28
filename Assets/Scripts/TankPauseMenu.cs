using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject hud;
    public GameObject Controls;
    public Image imageToShow1;
    public Image imageToShow2;
    public Image imageToShow3;
    
    private bool isPaused = false;
    private bool isControls = false;
    public static bool isEndGame = false;

    private void Start()
    {
        isEndGame = false;
    }

    void Update()
    {

        if (!isEndGame && Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (!isControls)
            {
                if (isPaused)
                {
                    ResumeGame();
                    imageToShow1.enabled = false;
                    imageToShow2.enabled = false;
                    imageToShow3.enabled = false;
                }
                else
                {
                    PauseGame();
                }
            } 
            else 
            {
                isControls = false;
                Controls.SetActive(false);
                pauseMenuUI.SetActive(true);
                hud.SetActive(true);
            }            
        }
    }

    void PauseGame()
    {
        isPaused = true;
        //hud.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenuUI.SetActive(false);
        //hud.SetActive(true);
        Time.timeScale = 1f;
    }

    public void PlayButton()
    {
        isPaused = false;
        pauseMenuUI.SetActive(false);
        hud.SetActive(true);
        Time.timeScale = 1f;
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Le Jeu se ferme ohalala");
    }

    public void ControlsButton()
    {
        isControls = true;
        pauseMenuUI.SetActive(false);
        Controls.SetActive(true);
        hud.SetActive(false);
        imageToShow1.enabled = false;
    }

    public void BackToPauseMenuCross()
    {
        isControls = false;
        Controls.SetActive(false);
        pauseMenuUI.SetActive(true);
        hud.SetActive(true);
    }
    
    
}