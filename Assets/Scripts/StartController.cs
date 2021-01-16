﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("vida", 3);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Space")) {

			SceneManager.LoadScene ("Fase 1");
		}
	}
}