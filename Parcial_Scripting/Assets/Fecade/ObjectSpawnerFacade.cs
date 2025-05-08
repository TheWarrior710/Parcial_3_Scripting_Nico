using UnityEngine;

public class ObjectSpawnerFacade
{
    private IObjectFactory currentFactory;

    public void SetFactory(IObjectFactory factory)
    {
        currentFactory = factory;
    }

    public void SpawnObject(Vector3 position)
    {
        currentFactory?.CreateObject(position);
    }
}
