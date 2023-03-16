 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = new GameObject().AddComponent<GameManager>();
                // name it for easy recognition
                _instance.name = _instance.GetType().ToString();
                // mark root as DontDestroyOnLoad();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    public GameObject gameOverCanvas;
    public bool isOver;

    private void Awake()
    {
        _instance = this;
    }
    
    public void Pause(GameObject pauseCanvas)
    {
        if(isOver == false)
        {
            // Pause the game
            Time.timeScale = 0f;

            // Show the pause canvas
            pauseCanvas.SetActive(true);
        }
        
    }

    public void Resume(GameObject pauseCanvas)
    {
        // Hide the pause canvas
        pauseCanvas.SetActive(false);

        // Resume the game
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        // Pause the game
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        isOver = true;
        gameOverCanvas.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Sxe");
    }

    public void MainMenu()
    {
        isOver = false;
        SceneManager.LoadScene("Menu");
    }
}
