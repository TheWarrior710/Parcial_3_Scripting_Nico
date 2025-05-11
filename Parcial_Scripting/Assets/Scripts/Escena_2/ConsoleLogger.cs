using UnityEngine;

public class ConsoleLogger : MonoBehaviour
{
    void OnEnable()
    {
        ClickBroadcaster.OnButtonClicked += LogNumber;
    }

    void OnDisable()
    {
        ClickBroadcaster.OnButtonClicked -= LogNumber;
    }

    void LogNumber(int num)
    {
        Debug.Log("Número actual del clic: " + num);
    }
}
