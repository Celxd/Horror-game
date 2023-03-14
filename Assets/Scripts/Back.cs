using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void ReturnToMainMenuButton()
    {
        // Load the main menu scene using the scene's name or index
        SceneManager.LoadScene("Menu");
    }
}
