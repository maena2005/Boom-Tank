using UnityEngine;

public class Target : MonoBehaviour
{
    private TargetCounter _targetCounter;

    void Start()
    {
        _targetCounter = FindFirstObjectByType<TargetCounter>();
    }

    void OnDestroy()
    {
        if (_targetCounter != null)
        {
            _targetCounter.TargetDestroyed();
        }
    }
}