using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Variavel responsavel por referenciar o Animator Controller.
	public Animator animator;

	//Intensidade do pulo.
	public int jumpForce;

	public int velocity;

	//Transform contendo a posição do objeto groundCheck.
	public Transform groundCheck;

	//Camada do chão.
	public LayerMask isFloor;

	//Instancia do Rigidbody do personagem.
	public Rigidbody2D body;

	//Variavel que indica se o player está no chão.
	public bool inFloor;

	// Use para inicialização.
	void Start () {

	}
	
	// Chamado cada vez que o frame é atualizado.
	void Update () {

		//Recebe o estado do botão Run.
		bool run = Input.GetButton ("Run");

		//Recebe o estado do botão Fire
		bool fire = Input.GetButton ("Fire");

		//Recebe o estado do botão Attack
		bool attack = Input.GetButton ("Attack");

		bool jump = Input.GetButtonDown ("Jump");

		//Recebe o estado do botão Slide.
		bool slide = Input.GetButtonDown ("Slide");

		//Cria uma região para verificação, de raio 0.2, situada na mesma posição do objeto
		//groundCheck, verificando a camada isFloor.
		//Salva true caso esteja no chão, e false caso esteja no ar.
		inFloor = Physics2D.OverlapCircle (groundCheck.position, 0.05f, isFloor);
			
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right*velocity*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			run = true;
		} else if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right*velocity*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
			run = true;
		}

		//Verificação se o player está no chão e pressionou o botão jump.
		if (inFloor & jump) {
			body.AddForce (new Vector2(0, jumpForce));
		}

		//Passa o estado do botão run para a Animation Controller, para o parametro run.
		animator.SetBool ("run", run);

		//Passa o estado do botão jump para a Animation Controller, para o parametro jump.
		animator.SetBool ("jump", !inFloor);

		//Passa o estado do botão fire para a Animation Controller, para o parametro fire.
		animator.SetBool ("fire", fire);

		//Passa o estado do botão slide para a Animation Controller, para o parametro slide.
		animator.SetBool ("slide", slide);

		//Passa o estado do botão attck para a Animation Controller, para o parametro attack.
		animator.SetBool ("attack", attack);
	
	}

}
