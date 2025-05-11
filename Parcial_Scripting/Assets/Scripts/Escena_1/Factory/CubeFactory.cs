using UnityEngine;

public class CubeFactory : IObjectFactory
{
    private GameObject prefab;

    public CubeFactory(GameObject cubePrefab)
    {
        prefab = cubePrefab;
    }

    public GameObject CreateObject(Vector3 position)
    {
        return Object.Instantiate(prefab, position, Quaternion.identity);
    }
}

