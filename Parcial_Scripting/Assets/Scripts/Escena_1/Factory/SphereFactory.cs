using UnityEngine;

public class SphereFactory : IObjectFactory
{
    private GameObject prefab;

    public SphereFactory(GameObject spherePrefab)
    {
        prefab = spherePrefab;
    }

    public GameObject CreateObject(Vector3 position)
    {
        return Object.Instantiate(prefab, position, Quaternion.identity);
    }
}