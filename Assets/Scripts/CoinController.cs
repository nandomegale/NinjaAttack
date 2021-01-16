using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {


	public LayerMask playerMask;
	public Text countCoin;
	public AudioSource audioSource;
	public AudioClip audioclip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics2D.OverlapCircle (transform.position, 0.05f, playerMask)) {
			countCoin.text = "" + (System.Int32.Parse(countCoin.text.ToString()) +1);
			audioSource.PlayOneShot (audioclip);
			Destroy (gameObject);

		
		}
		
	}
}
