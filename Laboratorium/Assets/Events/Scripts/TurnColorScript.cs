using UnityEngine;
using System.Collections;

public class TurnColorScript : MonoBehaviour
{
    public Renderer objectRenderer;
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }


    void TurnColor(float randomValue)
    {
        Color col = new Color(0.5f, 0.2f, randomValue);
        objectRenderer.material.color = col;
    }
}