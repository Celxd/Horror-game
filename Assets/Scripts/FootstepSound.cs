using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{

    // Define variables
    public AudioClip footstepAudio; // Sound clip for footstep
    public float footstepVolume = 0.5f; // Volume of footstep sound
    public float footstepPitch = 1.0f; // Pitch of footstep sound
    public float footstepDelay = 0.5f; // Delay between footstep sounds
    private float nextFootstep = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Check if it's time to play the next footstep sound
        if (Time.time > nextFootstep)
        {
            // Play the footstep sound
            AudioSource.PlayClipAtPoint(footstepAudio, transform.position, footstepVolume);
            // Set the delay for the next footstep sound
            nextFootstep = Time.time + footstepDelay;
        }
    }
}
