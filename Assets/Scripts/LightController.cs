using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light targetLight;
    public float offIntensity = 0f;
    public float onIntensity = 1f;

    private bool isOn = true;

    void Start()
    {
        // set light to on by default
        targetLight.intensity = onIntensity;
    }

    void Update()
    {
        // toggle light on/off when fuckin is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            targetLight.intensity = isOn ? onIntensity : offIntensity;
        }
    }
}
