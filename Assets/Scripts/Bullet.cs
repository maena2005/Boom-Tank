using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cible"))
        {
            Destroy(collision.gameObject);
        }
        
        Destroy(gameObject);
    }
}
