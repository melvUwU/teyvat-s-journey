using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        Debug.Log("click");
        SceneManager.LoadScene(sceneName);
    }
}
