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
    public GameObject[] listCounter;

    private bool gamePaused = false;

    void Start()
    {
        targetsDestroyed = 0;
        listCounter[0].SetActive(true);
        UpdateCounter();
    }

    public void TargetDestroyed()
    {

        if (listCounter != null && listCounter[targetsDestroyed] != null)
            listCounter[targetsDestroyed].SetActive(false);
        targetsDestroyed++;
        if (listCounter != null && listCounter[targetsDestroyed] != null)
            listCounter[targetsDestroyed].SetActive(true);
        UpdateCounter();

        
        if (targetsDestroyed == totalTargets)
        {
            ShowVictoryScreen();
        }
    }

    void UpdateCounter()
    {
        
        counterText.text = targetsDestroyed + " / " + totalTargets;
    }

    void ShowVictoryScreen()
    {
        
        hudCanvas.SetActive(false);
        
        victoryCanvas.SetActive(true);
        
        //Time.timeScale = 0f;
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