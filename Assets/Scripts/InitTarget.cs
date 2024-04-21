using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitTarget : MonoBehaviour
{
    public GameObject[] listTargets;
    private TargetCounter _targetCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        _targetCounter = FindFirstObjectByType<TargetCounter>();
        
        RandomTargets();
        listTargets = GameObject.FindGameObjectsWithTag("Target");
        InitTargets(listTargets,false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
        */
    }

    private void RandomTargets()
    {
        for (var i = 0; i < _targetCounter.totalTargets; i++)
        {
            listTargets = GameObject.FindGameObjectsWithTag("Target");
            var iRnd = Random.Range(0, listTargets.Length);
            listTargets[iRnd].tag = "TargetShow";
        }

    }

    private void InitTargets(GameObject[] list, bool show)
    {
        for (var i = 0; i < list.Length; i++)
        {
            list[i].SetActive(show);
        }
    }
}
