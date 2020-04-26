using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction(float randomValue);
    public static event ClickAction OnClicked;


    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            //if (OnClicked != null)
            //    OnClicked();

            OnClicked?.Invoke(Random.value);
        }
    }
}