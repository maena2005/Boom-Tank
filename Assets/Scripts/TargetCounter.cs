using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetCounter : MonoBehaviour
{
    public int totalTargets;
    private int remainingTargets;
    public TextMeshProUGUI counterText;
    public GameObject victoryCanvas; 
    public GameObject hudCanvas; 
    public Timer timer; 

    private bool gamePaused = false;

    void Start()
    {
        remainingTargets = totalTargets;
        UpdateCounter();
        timer.StartTimer(); 
    }

    public void TargetDestroyed()
    {
        remainingTargets--;
        UpdateCounter();

        
        if (remainingTargets <= 0)
        {
            
            timer.StopTimer();
            
            ShowVictoryScreen();
        }
    }

    void UpdateCounter()
    {
        counterText.text = "Target left : " + remainingTargets + " / 5";
    }

    void ShowVictoryScreen()
    {
        
        hudCanvas.SetActive(false);
        
        victoryCanvas.SetActive(true);
        
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void ResumeGame()
    {
        
        hudCanvas.SetActive(true);
        
        victoryCanvas.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    
}