using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Exit : MonoBehaviour
{

    public void OnExitButtonClick()
    {
        Debug.Log("Exiting the application...");
        Application.Quit();
    }
}
