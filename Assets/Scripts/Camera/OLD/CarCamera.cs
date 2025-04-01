using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour
{
    public Transform carTransform;

    public float distance = 10f;
    public float height = 5f;

    public float cameraSpeed = 10f;
    public float lookSpeed = 10f;

    private void FixedUpdate()
    {
        //Caluclate the desired position as a point directly behind the car
        Vector3 offset = carTransform.forward * (-1) * distance + carTransform.up * height;
        Vector3 desiredPosition = carTransform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, cameraSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        //Rotate the camera to look at the car
        Quaternion desiredRotation = Quaternion.LookRotation(carTransform.position - transform.position);
        Quaternion smoothedRotation = Quaternion.Lerp(transform.rotation, desiredRotation, lookSpeed * Time.deltaTime);
        transform.rotation = smoothedRotation;
    }
}
