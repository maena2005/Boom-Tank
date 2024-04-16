using UnityEngine;

public class Target : MonoBehaviour
{
    private TargetCounter targetCounter;

    void Start()
    {
        targetCounter = FindObjectOfType<TargetCounter>();
    }

    void OnDestroy()
    {
        if (targetCounter != null)
        {
            targetCounter.TargetDestroyed();
        }
    }
}