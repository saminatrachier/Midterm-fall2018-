﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{	
			SceneManager.LoadScene("SampleScene");
			Time.timeScale = 1.0f;
			ScoreText.Score = 0;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{	
			Application.Quit();
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{	
			SceneManager.LoadScene("SampleScene");
		}
	}
	
}
