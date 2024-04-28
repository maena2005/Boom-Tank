using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string Game;
    public string Settings;
    
    public void PlayButton()
    {
        SceneManager.LoadScene(Game);
    }

    public void ControlButton()
    {
        SceneManager.LoadScene(Settings);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Tu quittes vraiment le jeu là ?....");
    }
}
