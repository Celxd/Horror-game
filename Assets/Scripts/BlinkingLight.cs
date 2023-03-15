using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    public Light targetLight;
    public float blinkDuration = 0.1f; // Duration of each blink
    public float blinkCooldown = 2f; // Cooldown period between blinks

    private float blinkTimer = 0f; // Timer for tracking blink duration and cooldown
    private bool isBlinking = false; // Whether the light is currently blinking
    private float originalIntensity; // Original intensity value of the light

    private void Start()
    {
        if (targetLight == null)
        {
            targetLight = GetComponent<Light>();
        }

        // Store the original intensity value of the light
        originalIntensity = targetLight.intensity;
    }

    private void Update()
    {
        // If the light is not currently blinking, start a new blink cycle
        if (!isBlinking)
        {
            // Reset the timer
            blinkTimer = 0f;

            // Set the light to the minimum intensity
            targetLight.intensity = 0f;

            // Set the flag to indicate that the light is now blinking
            isBlinking = true;
        }
        // If the light is currently blinking, update the blink timer
        else
        {
            blinkTimer += Time.deltaTime;

            // If the blink duration has elapsed, switch off the light
            if (blinkTimer >= blinkDuration)
            {
                targetLight.intensity = 0f;
            }

            // If the cooldown period has elapsed, reset the blink cycle
            if (blinkTimer >= blinkCooldown)
            {
                // Set the light back to its original intensity value
                targetLight.intensity = originalIntensity;

                // Set the flag to indicate that the light is no longer blinking
                isBlinking = false;
            }
        }
    }

    // Public method to change the intensity of the light
    public void SetIntensity(float intensity)
    {
        targetLight.intensity = intensity;
    }
}
