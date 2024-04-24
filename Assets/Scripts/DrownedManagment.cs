using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrownedManagment : MonoBehaviour
{
    public GameObject DrownedScreen;
    public GameObject HUD;
    private bool tankEntered;
    private WaitForSeconds delayBeforeGameOver = new WaitForSeconds(0.3f);
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
        DrownedScreen.SetActive(true);
    }
}
