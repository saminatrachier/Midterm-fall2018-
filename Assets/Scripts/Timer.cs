using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

//USUAGE: add a timer to the game scene
public class Timer : MonoBehaviour
{
    public float timeLeft = 30.0f;
    public Text endText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        endText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            Time.timeScale = 0.0f;
        }
    }
}
