using UnityEngine;

public class CylinderFactory : IObjectFactory
{
    private GameObject prefab;

    public CylinderFactory(GameObject cylinderPrefab)
    {
        prefab = cylinderPrefab;
    }

    public GameObject CreateObject(Vector3 position)
    {
        return Object.Instantiate(prefab, position, Quaternion.identity);
    }

}