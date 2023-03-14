using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        // Pause the game
        Time.timeScale = 0f;

        // Show the pause canvas
        pauseCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        // Hide the pause canvas
        pauseCanvas.SetActive(false);

        // Resume the game
        Time.timeScale = 1f;
    }
}
