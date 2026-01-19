using UnityEngine;
using UnityEngine.InputSystem;

//Teleports player to a platform outside the room
public class Teleport : MonoBehaviour
{
    //To check if player has teleported to the platform outside
    public bool teleported = false;

    public InputActionReference action;
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            //Checking if teleported to the platform or not
            if (teleported == false)
            {
                //Not teleported --> Teleport 30 units to the right (platform location)
                transform.position = Vector3.right * 30f;
                teleported = true;
            } else {
                //Has teleported --> Teleport back to starting position
                transform.position = Vector3.zero;
                teleported = false;
            }
        };
    }
}
