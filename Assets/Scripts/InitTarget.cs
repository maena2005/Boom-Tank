using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitTarget : MonoBehaviour
{
    public GameObject[] listTargets;
    public GameObject[] listInitTargets;
    private TargetCounter targetCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        targetCounter = FindObjectOfType<TargetCounter>();
        
        listInitTargets = GameObject.FindGameObjectsWithTag("Target");
        
        RandomTargets();
        listTargets = GameObject.FindGameObjectsWithTag("Target");
        InitTargets(listTargets,false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            listTargets = GameObject.FindGameObjectsWithTag("Target");
            for (var i = 0; i < listTargets.Length; i++)
            {
                listTargets[i].tag = "Target";
            }
            InitTargets(listInitTargets,true);

        }
    }

    private void RandomTargets()
    {
        for (var i = 0; i < targetCounter.totalTargets; i++)
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
