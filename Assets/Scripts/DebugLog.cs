using UnityEngine;

public class InputManagerConsoleDetect : MonoBehaviour
{
    private void Update()
    {
        // Check for keyboard input
        if (Input.anyKeyDown)
        {
            // Get the name of the key that was pressed
            string keyName = Input.inputString;

            // Print out the name of the key that was pressed
            Debug.Log("Key pressed: " + keyName);
        }

        // Check for mouse input
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            // Get the name of the button that was pressed
            string buttonName = "";

            if (Input.GetMouseButtonDown(0))
            {
                buttonName = "left mouse button";
            }
            else if (Input.GetMouseButtonDown(1))
            {
                buttonName = "right mouse button";
            }
            else if (Input.GetMouseButtonDown(2))
            {
                buttonName = "middle mouse button";
            }

            // Print out the name of the button that was pressed
            Debug.Log("Button pressed: " + buttonName);
        }

        // Check for joystick input
        string[] joystickNames = Input.GetJoystickNames();
        for (int i = 0; i < joystickNames.Length; i++)
        {
            if (joystickNames[i].Length == 0)
            {
                continue;
            }

            // Check for joystick button input
            for (int j = 0; j < 20; j++)
            {
                if (Input.GetKeyDown("joystick " + (i + 1) + " button " + j))
                {
                    Debug.Log("Joystick " + joystickNames[i] + " button " + j + " pressed.");
                }
            }

            // Check for joystick axis input
            float horizontalAxis = Input.GetAxis("Horizontal");
            float verticalAxis = Input.GetAxis("Vertical");
            if (horizontalAxis != 0.0f || verticalAxis != 0.0f)
            {
                Debug.Log("Joystick " + joystickNames[i] + " moved. Horizontal: " + horizontalAxis + ", Vertical: " + verticalAxis);
            }

            float rightHorizontalAxis = Input.GetAxisRaw("RightHorizontal");
            float rightVerticalAxis = Input.GetAxisRaw("RightVertical");
            if (rightHorizontalAxis != 0.0f || rightVerticalAxis != 0.0f)
            {
                Debug.Log("Joystick " + joystickNames[i] + " right stick moved. Horizontal: " + rightHorizontalAxis + ", Vertical: " + rightVerticalAxis);
            }
        }
    }
}
