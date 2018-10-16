using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//USAGE: get UI components for players when they click on a dog
public class ScoreText : MonoBehaviour
{
    private Text text;
    public static int Score;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Score.ToString();
    }
}
