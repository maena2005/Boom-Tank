using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{

    private Transform LocalTransform; //création variable position appelée LocalTransform
    private float x; //création variable nombre à virgule appelée x

    [SerializeField] private float maxSpeed = 10; //création autre variable à virgule de vitesse max 10
    // serializeField = pour afficher la varible sur l'inspector unity

    [SerializeField] private float rotationSpeed = 100; //création variable de rotation vitesse 100

    private Vector3 direction = new Vector3(0, 0, 1);
    //création vecteur en 3d avec coordonnées x=0, y=0, z=1 = dans quelle direction il regarde

    private float rotateAxis;
    private float moveAxis;

    // Start is called before the first frame update
    void Start() // se déroule au lancement du jeu
    {
        LocalTransform = GetComponent<Transform>(); // assigner le transform du gameobject (position) à la variable LocalTransform
        x = LocalTransform.position.x; // assigner la position de x du transform LocalTransform à la variable x (float du début)
    }

    // Update is called once per frame
    private void Update() // se déroule toutes les frames tout au long du jeu
    {
        /*
        LocalTransform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        LocalTransform.Translate(Input.GetAxis("Vertical") * Vector3.forward * maxSpeed * Time.deltaTime);
        */

        LocalTransform.Rotate(Vector3.up, rotateAxis * rotationSpeed * Time.deltaTime);
        LocalTransform.Translate(Vector3.forward * moveAxis * maxSpeed * Time.deltaTime);
    }

    public void HandleRotate(InputAction.CallbackContext Inputcontext)
    {
        rotateAxis = Inputcontext.ReadValue<float>();
        //Debug.Log("Rotate =" + rotateAxis);
    }
    public void HandleMove(InputAction.CallbackContext Inputcontext)
    {
        moveAxis = Inputcontext.ReadValue<float>();
        //Debug.Log("Move =" + moveAxis);
    }

    private void FixedUpdate() // se déroule toutes les 30 frames (on peut le choisir) => pour gagner perf
    {
    }

}
