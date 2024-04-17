using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetCounter : MonoBehaviour
{
    public int totalTargets;
    private int targetsDestroyed;
    public TextMeshProUGUI counterText;
    public GameObject victoryCanvas; 
    public GameObject hudCanvas; 
    public Timer timer; 

    private bool gamePaused = false;

    void Start()
    {
        targetsDestroyed = 0;
        UpdateCounter();
        timer.StartTimer(); 
    }

    public void TargetDestroyed()
    {
        targetsDestroyed++;
        UpdateCounter();

        
        if (targetsDestroyed == totalTargets)
        {
            
            timer.StopTimer();
            
            ShowVictoryScreen();
        }
    }

    void UpdateCounter()
    {
        counterText.text = "Targets destroyed: " + targetsDestroyed + " / " + totalTargets;
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