using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public abstract void OnHit(Collider other);

    public virtual void Launch(Vector3 direction, float force)
    {
        GetComponent<Rigidbody>().linearVelocity = direction * force;
    }


    private void OnTriggerEnter(Collider other)
    {
        OnHit(other);
        gameObject.SetActive(false); 
    }
}
