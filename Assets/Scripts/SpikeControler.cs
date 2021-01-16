using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpikeControler : MonoBehaviour {

	public Transform groundCheck;

	//public LayerMask playerMask;

	public LayerMask spikes;

	public Scene cena;

	public Text countHeart;

	// Use this for initialization
	void Start () {
		cena = SceneManager.GetActiveScene();

	}
	
	// Update is called once per frame
	void Update () {

		if (Physics2D.OverlapCircle (groundCheck.position, 0.05f, spikes)) {
			SceneManager.LoadScene (cena.name);
			//PlayerPrefs.SetInt ("vida", PlayerPrefs.GetInt ("vida") - 1);
			//countHeart.text = "" + PlayerPrefs.GetInt ("vida");
		}


	}

}