using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectilePool : MonoBehaviour
{
    public GameObject projectilePrefab;
    public int poolSize = 10;

    protected Queue<GameObject> pool = new Queue<GameObject>();

    protected virtual void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(projectilePrefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }

    public virtual GameObject GetProjectile()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            GameObject obj = Instantiate(projectilePrefab);
            return obj;
        }
    }

    public virtual void ReturnProjectile(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
