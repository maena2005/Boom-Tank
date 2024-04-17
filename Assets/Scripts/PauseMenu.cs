using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject hud;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
    }

    void PauseGame()
    {
        isPaused = true;
        hud.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenuUI.SetActive(false);
        hud.SetActive(true);
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
}