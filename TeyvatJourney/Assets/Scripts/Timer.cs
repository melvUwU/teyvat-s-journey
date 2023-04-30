using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timeCountdown = 60f;

    void Update()
    {

        if (timeCountdown <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        timeCountdown -= Time.deltaTime;
        timerText.text = Mathf.Round(timeCountdown).ToString();


    }
}
