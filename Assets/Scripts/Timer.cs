using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//USUAGE: add a timer to the game scene
public class Timer : MonoBehaviour
{
    public float timeLeft = 30.0f;
    public Text endText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        endText.text = ("Time Left: " + (int)timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
