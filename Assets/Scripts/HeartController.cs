using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartController : MonoBehaviour {


	public LayerMask playerMask;
	public Text countHeart;
	public AudioSource audioSource;
	public AudioClip audioclip;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Physics2D.OverlapCircle (transform.position, 0.05f, playerMask)) {
			PlayerPrefs.SetInt ("vida", PlayerPrefs.GetInt ("vida") + 1);
			countHeart.text = "" + PlayerPrefs.GetInt ("vida");
			audioSource.PlayOneShot (audioclip);
			Destroy (gameObject);


		}

	}
}