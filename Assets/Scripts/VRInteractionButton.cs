using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class VRInteractionButton : MonoBehaviour , IRayitem
{
    [SerializeField] private UnityEvent onButtonPressed;
    private bool _isHover;

    public void OnPointEnter()
    {
        transform.localScale = Vector3.one * 1.3f;
        _isHover = true;
    }
    public void OnPointExit()
    {
        transform.localScale = Vector3.one;
        _isHover = false;
    }
    private void Update()
    {
        if (_isHover && Input.GetMouseButtonDown(0)) 

        { 
            onButtonPressed.Invoke();
        }
        if(_isHover && Gamepad.current.selectButton.wasPressedThisFrame)
        {
            onButtonPressed.Invoke();
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        OnPointEnter();
    }
  
    private void OnTriggerExit(Collider other)
    {
        OnPointExit();
    }
}
