// ShooterController.cs
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public Transform firePoint;
    public ProjectileType1Pool pool1;
    public ProjectileType2Pool pool2;
    public ProjectileType3Pool pool3;

    private int currentType = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (Input.GetMouseButtonDown(1))
        {
            currentType = (currentType % 3) + 1;
            Debug.Log("Tipo de proyectil actual: " + currentType);
        }
    }

    void Shoot()
    {
        GameObject projectile = null;

        switch (currentType)
        {
            case 1:
                projectile = pool1.GetProjectile();
                break;
            case 2:
                projectile = pool2.GetProjectile();
                break;
            case 3:
                projectile = pool3.GetProjectile();
                break;
        }

        if (projectile != null)
        {
            projectile.transform.position = firePoint.position;
            projectile.transform.rotation = firePoint.rotation;
            projectile.GetComponent<Projectile>().Launch(firePoint.forward, 10f);
        }
    }
}
