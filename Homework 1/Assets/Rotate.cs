using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float degreesPerSecond = 5.0f;
    void Update()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
    }
}
