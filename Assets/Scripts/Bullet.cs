using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Animator animator; // Référence à l'Animator du mannequin

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            // Déclencher l'animation du mannequin si l'objet touché est une cible
            if (animator != null /*&& animator.isActiveAndEnabled*/) //&& animator.runtimeAnimatorController != null)
            {
                animator.SetBool("isHit", true); // Activer le paramètre IsHit dans l'Animator
            }            
            Destroy(collision.gameObject);
            
        }
        
        Destroy(gameObject);
    }
}