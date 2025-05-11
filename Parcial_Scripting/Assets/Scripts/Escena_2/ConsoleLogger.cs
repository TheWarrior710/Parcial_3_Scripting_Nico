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
        Debug.Log("N�mero actual del clic: " + num);
    }
}
