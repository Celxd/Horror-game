using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Doorscript : MonoBehaviour
{
    public CinemachineVirtualCamera playerCamera;
    [Header("MaxDistance you can open the door.")]
    public float maxDistance = 5;

    private bool isOpen = false;
    private Animator anim;

    void Update()
    {
        // This will check if the player press the Interact button.
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pressed();
            Debug.Log("You Press E");
        }
    }

    void Pressed()
    {
        // This will get the raycasthit information of the object that the raycast hits.
        RaycastHit hit;

        // This will get the Camera component from the CinemachineVirtualCamera component.
        Camera camera = playerCamera.GetComponentInChildren<Camera>();

        // This will create a ray that starts at the camera and points forward.
        Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        // This will check if the ray hits something within the maxDistance.
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            // If the raycast hits, then it checks if it hit an object with the tag "Door".
            if (hit.transform.tag == "Door")
            {
                // This line will get the Animator from the parent of the door that was hit by the raycast.
                anim = hit.transform.GetComponentInParent<Animator>();

                // This will set the bool the opposite of what it is.
                isOpen = !isOpen;

                // This line will set the bool true so it will play the animation.
                anim.SetBool("Open", isOpen);
            }
        }
    }
}
