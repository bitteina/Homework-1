using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (transform.position == Vector3.zero)
            {
                transform.position = Vector3.right * 30f;
            } else {
                transform.position = Vector3.zero;
            }
        };
    }
}
