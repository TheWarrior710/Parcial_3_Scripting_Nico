using UnityEngine;

public class ProjectileType3 : Projectile
{
    private ParticleSystem impactParticles;

    private void Awake()
    {
        impactParticles = GetComponentInChildren<ParticleSystem>(true); 
    }

    public override void OnHit(Collider other)
    {
        if (impactParticles != null)
        {
            impactParticles.gameObject.SetActive(true);
            impactParticles.Play();
        }

        Debug.Log("Impacto del proyectil tipo 3 con efecto.");
    }
}


