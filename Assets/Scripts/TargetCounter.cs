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
        PauseMenu.isEndGame = true;
    }
    
}