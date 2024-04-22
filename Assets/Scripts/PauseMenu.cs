using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject hud;
    public GameObject Controls;

    private bool isPaused = false;
    private bool isControls = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isControls == false)
        {
            if (isPaused)
            {
                ResumeGame();
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
    }

    public void BackToPauseMenuCross()
    {
        isControls = false;
        Controls.SetActive(false);
        pauseMenuUI.SetActive(true);
        hud.SetActive(true);
    }
    
    
}