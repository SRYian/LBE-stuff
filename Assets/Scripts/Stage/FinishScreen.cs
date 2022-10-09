using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScreen : MonoBehaviour
{
    public void RetryButton()
    {
        Debug.Log("retry");
        SceneManager.LoadScene("Playing Scene");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
