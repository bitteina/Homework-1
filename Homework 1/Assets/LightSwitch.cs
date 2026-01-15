using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        //Here should check if B button is pressed!! tab only temporarily
        //if (Input.GetKeyDown("tab"))
        //{
        //    light.color = Color.blue;
        //}
        action.action.performed += (ctx) =>
        {
            light.color = Color.blue;
        };
    }
}
