using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Reference to the animation component
    public Animation doorAnimation;

    // Flag to indicate whether the door is currently opening
    private bool isOpening = false;

    // Called when the player clicks on the door object
    void OnMouseDown()
    {
        // Check if the door is already opening
        if (!isOpening && doorAnimation != null)
        {
            // Set the flag to indicate that the door is opening
            isOpening = true;

            // Play the door opening animation
            doorAnimation.Play("Door");
        }
    }

    // Called when the door opening animation finishes playing
    void DoorOpenAnimationFinished()
    {
        // Set the flag to indicate that the door is no longer opening
        isOpening = false;
    }
}
