using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TowerRotation : MonoBehaviour
{
    private Transform TowerTransform;
    private float rotateTowerAxis;
    private float rotationSpeed = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        TowerTransform = GetComponent<Transform>(); // assigner le transform du gameobject (position) à la variable LocalTransform
    }

    // Update is called once per frame
    private void Update()
    {
        TowerTransform.Rotate(Vector3.up, rotateTowerAxis * rotationSpeed * Time.deltaTime);
    }
    
    public void HandleTowerRotate(InputAction.CallbackContext Inputcontext)
    {
        rotateTowerAxis = Inputcontext.ReadValue<float>();
        Debug.Log("Rotate Tower =" + rotateTowerAxis);
    }
}
