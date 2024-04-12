using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string Desert;
    public string Settings;
    
    public void PlayButton()
    {
        SceneManager.LoadScene(Desert);
    }

    public void SettingButton()
    {
        SceneManager.LoadScene(Settings);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Tu quittes vraiment le jeu là ?....");
    }
}
