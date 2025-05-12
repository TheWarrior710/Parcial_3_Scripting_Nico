using UnityEngine;
using System.Collections;

public class ProjectileType2 : Projectile
{
    public override void OnHit(Collider other)
    {
        Debug.Log("Impacto del proyectil tipo 2. Desactivando collider...");
        other.enabled = false;
        StartCoroutine(ReenableCollider(other));
    }

    private IEnumerator ReenableCollider(Collider col)
    {
        yield return new WaitForSeconds(1f);
        col.enabled = true;
        Debug.Log("Collider reactivado.");
    }

 

}

