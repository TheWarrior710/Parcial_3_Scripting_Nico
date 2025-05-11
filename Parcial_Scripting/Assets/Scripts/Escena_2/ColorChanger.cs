using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    void OnEnable()
    {
        ClickBroadcaster.OnButtonClicked += ChangeColor;
    }

    void OnDisable()
    {
        ClickBroadcaster.OnButtonClicked -= ChangeColor;
    }

    void ChangeColor(int num)
    {
        switch (num)
        {
            case 1: rend.material.color = Color.red; break;
            case 2: rend.material.color = Color.green; break;
            case 3: rend.material.color = Color.blue; break;
            case 4: rend.material.color = Color.yellow; break;
        }
    }
}
