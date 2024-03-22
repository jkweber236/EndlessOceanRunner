using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Stores the speed at which the camera moves horizontally
    public float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        // Move the camera horizontally based on the camera speed
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
