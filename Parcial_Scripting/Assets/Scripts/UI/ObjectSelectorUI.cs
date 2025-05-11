using UnityEngine;
using UnityEngine.UI;

public class ObjectSelectorUI : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    public Button cubeButton;
    public Button sphereButton;
    public Button cylinderButton;
    public Button spawnButton;
    public Button returnButton;

    private ObjectSpawnerFacade spawnerFacade;

    void Start()
    {
        spawnerFacade = new ObjectSpawnerFacade();

        cubeButton.onClick.AddListener(() =>
            spawnerFacade.SetFactory(new CubeFactory(cubePrefab)));

        sphereButton.onClick.AddListener(() =>
            spawnerFacade.SetFactory(new SphereFactory(spherePrefab)));

        cylinderButton.onClick.AddListener(() =>
            spawnerFacade.SetFactory(new CylinderFactory(cylinderPrefab)));

        spawnButton.onClick.AddListener(() =>
            spawnerFacade.SpawnObject(GetSpawnPosition()));

        returnButton.onClick.AddListener(() =>
            UnityEngine.SceneManagement.SceneManager.LoadScene("SceneMaster"));
    }

    Vector3 GetSpawnPosition()
    {
        return new Vector3(Random.Range(-5f, 5f), 1f, Random.Range(-5f, 5f));
    }
}
