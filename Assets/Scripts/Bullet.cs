using UnityEngine;

public class Bullet : MonoBehaviour
{
    private TargetCounter _targetCounter;

    void Start()
    {
        _targetCounter = FindFirstObjectByType<TargetCounter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TargetShow"))
        {
            // Déclencher l'animation du mannequin si l'objet touché est une cible
            collision.gameObject.GetComponent<Animator>().SetBool("isHit", true); // Activer le paramètre IsHit dans l'Animator
            
            if (_targetCounter != null)
            {
                _targetCounter.TargetDestroyed();
            }
        }
        
        Destroy(gameObject);
    }
}