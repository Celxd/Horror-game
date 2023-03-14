using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseCanvas;
    
    void Update()
    {
        //Pause using esc
        if (Input.GetKeyDown(KeyCode.Escape))
            GameManager.Instance.Pause(pauseCanvas);

        //Resume using space
        if (Input.GetKeyDown(KeyCode.Space) && pauseCanvas.activeSelf == true)
            GameManager.Instance.Resume(pauseCanvas);
    }
}
