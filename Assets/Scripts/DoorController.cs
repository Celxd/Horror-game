using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Rotation angle in degrees
    public float rotationAngle = -45f;

    // Speed of rotation in degrees per second
    public float rotationSpeed = 2f; // Decreased the value to slow down rotation

    // Flag to indicate whether the door is rotating
    private bool isRotating = false;

    // Update is called once per frame
    void Update()
    {
        // Check if the door is rotating
        if (isRotating)
        {
            // Calculate the rotation amount based on time and speed
            float rotationAmount = rotationSpeed * Time.deltaTime;

            // Rotate the door around the y-axis
            transform.Rotate(0f, rotationAmount, 0f, Space.Self);

            // Check if the door has rotated the desired amount
            if (Mathf.Abs(transform.rotation.eulerAngles.y) >= Mathf.Abs(rotationAngle))
            {
                // Stop the rotation and reset the rotation angle
                isRotating = false;
                transform.rotation = Quaternion.Euler(0f, rotationAngle, 0f);
            }
        }
    }

    // Called when the player clicks on the door object
    void OnMouseDown()
    {
        // Start the rotation
        isRotating = true;
    }
}
