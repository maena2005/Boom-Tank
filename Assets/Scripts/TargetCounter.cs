using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetCounter : MonoBehaviour
{
    public int totalTargets;
    private int _targetsDestroyed;
    public GameObject victoryCanvas; 
    public GameObject hudCanvas;
    public GameObject[] listCounter;

    //private bool _gamePaused = false;

    void Start()
    {
        hudCanvas.SetActive(true);
        victoryCanvas.SetActive(false);
        
        _targetsDestroyed = 0;
        listCounter[0].SetActive(true);
    }

    public void TargetDestroyed()
    {
        _targetsDestroyed++;

        if (_targetsDestroyed <= totalTargets)
        {
            listCounter[_targetsDestroyed - 1 ].SetActive(false);
            listCounter[_targetsDestroyed].SetActive(true);
        }
        
        if (_targetsDestroyed == totalTargets)
        {
            ShowVictoryScreen();
        }
    }

    void ShowVictoryScreen()
    {
        
        hudCanvas.SetActive(false);
        
        victoryCanvas.SetActive(true);
        
        Time.timeScale = 0f;
        //_gamePaused = true;
    }

    public void ResumeGame()
    {
        
        hudCanvas.SetActive(true);
        
        victoryCanvas.SetActive(false);
        Time.timeScale = 1f;
        //_gamePaused = false;
    }

    
}