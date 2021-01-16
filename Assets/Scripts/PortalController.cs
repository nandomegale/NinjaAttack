using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour {

	public Transform groundCheck;

	public LayerMask portal;

	public Scene cena;

	// Use this for initialization
	void Start () {
		
		cena = SceneManager.GetActiveScene();

	}

	// Update is called once per frame
	void Update () {

		if (Physics2D.OverlapCircle (groundCheck.position, 0.05f, portal)) {

			if (cena.name == "Fase 1") {
				SceneManager.LoadScene ("Fase 2");
			} else if (cena.name == "Fase 2") {
				SceneManager.LoadScene ("Fase 3");
			} else if (cena.name == "Fase 3") {
				SceneManager.LoadScene ("Fase 4");
			} else if (cena.name == "Fase 4") {
				SceneManager.LoadScene ("Fase 5");
			} else if (cena.name == "Fase 5") {
				SceneManager.LoadScene ("gamewin");
			}
		}
	}
}
