using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float speed = 10f;               // Spaceship speed
    public float rotationSpeed = 100f;      // Rotation speed

    private float rollSpeed = 50f;          // Roll speed
    private float yaw = 0f;                 // Yaw angle
    private float pitch = 0f;               // Pitch angle
    private float roll = 0f;                // Roll angle

    void Update()
    {
        // Keyboard input
        float forward = Input.GetAxis("Vertical");     // W, S or Up, Down arrow keys
        float strafe = Input.GetAxis("Horizontal");    // A, D or Left, Right arrow keys
        float rollInput = Input.GetAxis("Roll");       // Q, E or Numpad 4, Numpad 6 keys
        float speedInput = Input.GetAxis("Speed");     // R, F or Numpad 8, Numpad 2 keys

        // Update yaw, pitch, and roll based on mouse input
        yaw += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        roll += rollInput * rollSpeed * Time.deltaTime;

        // Clamp pitch angle to prevent spaceship from flipping over
        pitch = Mathf.Clamp(pitch, -60f, 60f);

        // Calculate direction and speed of spaceship
        Vector3 direction = new Vector3(strafe, 0, forward).normalized;
        float currentSpeed = speed + speedInput * speed;

        // Rotate spaceship based on yaw, pitch, and roll angles
        transform.rotation = Quaternion.Euler(pitch, yaw, roll);

        // Move spaceship in direction and speed
        transform.position += transform.forward * currentSpeed * Time.deltaTime * direction.z;
        transform.position += transform.right * currentSpeed * Time.deltaTime * direction.x;
    }
}

