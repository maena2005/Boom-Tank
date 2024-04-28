using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20;
    public float fireRate = 2f; 
    private float nextFireTime = 0f; 

    void Update()
    {

        if (Time.time >= nextFireTime && Input.GetKeyDown(KeyCode.Space))
        {

            ShootBullet();

            nextFireTime = Time.time + fireRate;
        }
    }

    void ShootBullet()
    {

        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
