using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

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
    private bool isDrowned = false;
    
    public string MainMenu;
    
    //For DrownedManagmentCS
    public GameObject DrownedScreen;
    public GameObject HUD;
    private bool tankEntered;
    private WaitForSeconds delayBeforeGameOver = new WaitForSeconds(0.3f);
    //-----------------------------//
    private void Start()
    {
        //Time.timeScale = 1f;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && isControls == false && isDrowned == false)
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

        if (Input.GetKeyDown(KeyCode.Escape) && isControls == true)
        {
            isControls = false;
            Controls.SetActive(false);
            pauseMenuUI.SetActive(true);
            hud.SetActive(true);
        }
    }
    
    //For DrownedManagmentCS
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tank") && !tankEntered)
        {
            tankEntered = true;
            StartCoroutine(ShowGameOverAfterDelay());
        }
    }

    private IEnumerator ShowGameOverAfterDelay()
    {
        yield return delayBeforeGameOver;
        Time.timeScale = 0f;
        HUD.SetActive(false);
        isDrowned = true;
        DrownedScreen.SetActive(true);
    }
    //-----------------------------//
    public void MainMenuButton()
    {
        isDrowned = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(MainMenu);
        
    }
    
    public void PlayAgainButton()
    {
        isDrowned = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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