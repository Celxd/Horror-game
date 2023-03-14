using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    // Reference to the toggle button UI element
    public Toggle fullscreenToggle;

    private void Start()
    {
        // Set the initial value of the toggle button based on whether the game is currently in fullscreen mode
        fullscreenToggle.isOn = Screen.fullScreen;
        Debug.Log("Fullscreen");
    }

    public void ToggleFullscreen()
    {
        // Toggle between fullscreen and windowed mode
        Screen.fullScreen = !Screen.fullScreen;
    }
}
