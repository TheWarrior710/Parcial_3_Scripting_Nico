using UnityEngine;

public class ProjectileType1 : Projectile
{
    public override void OnHit(Collider other)
    {
        Debug.Log("Impacto del proyectil tipo 1");
    }
}
