using UnityEngine;
using System;

public class ClickBroadcaster : MonoBehaviour
{
    public static event Action<int> OnButtonClicked;

    private int clickCount = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount = (clickCount % 4) + 1; 
            OnButtonClicked?.Invoke(clickCount);
        }
    }
}
