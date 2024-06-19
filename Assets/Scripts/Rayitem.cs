using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayitem : MonoBehaviour, IRayitem
{   
    [SerializeField] Color deActiveColor;
    [SerializeField] Color activeColor;
    [SerializeField] Renderer gameObjectRenderer;

    public void Start()
    {
        //gameObjectRenderer = GetComponent<Renderer>();
        gameObjectRenderer.material.color = deActiveColor;
    }

    public void OnPointEnter()
    {
        Debug.Log("OnPointerEnter");
        gameObjectRenderer.material.color = activeColor;
        UIManager.Instance.showInfoPanel(gameObject, transform.position);
    }

    public void OnPointExit()
    {
        Debug.Log("OnPointerExit");
        gameObjectRenderer.material.color = deActiveColor;
    }
}
