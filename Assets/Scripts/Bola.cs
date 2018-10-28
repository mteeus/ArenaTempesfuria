using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	float sorteio;
	float sorteioy;
	public bool primeiraVez;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody2D>();
		primeiraVez=true;
		if (primeiraVez){
		sorteio = Random.Range(0,10);
		sorteioy=Random.Range(0.02f,-0.02f);

		if(sorteio<5){
			rb.AddForce(new Vector2(0.05f,sorteioy));
		}else {
			rb.AddForce(new Vector2(-0.05f,sorteioy));
		}
	}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") && Time.timeScale==0  ){
			Time.timeScale=1;
			sorteio = Random.Range(0,10);
		sorteioy=Random.Range(0.02f,-0.02f);

		if(sorteio<5){
			rb.AddForce(new Vector2(0.05f,sorteioy));
		}else {
			rb.AddForce(new Vector2(-0.05f,sorteioy));
		}
		}
	}
	void OnCollisionEnter2D (Collision2D outro){
		if (outro.gameObject.tag=="Player"){
			rb.velocity=rb.velocity + outro.gameObject.GetComponent<Rigidbody2D>().velocity/3; 

		}

	}
	void OnTriggerEnter2D (Collider2D parede){
		if (parede.gameObject.tag=="Parededir"){
			pontuacao.pontos1++;
		}else if (parede.gameObject.tag=="Paredeesq"){
			pontuacao.pontos2++;
		}

		}
		void OnTriggerExit2D(Collider2D parede){
			if (parede.gameObject.tag == "Parededir" || parede.gameObject.tag == "Paredeesq"){
				transform.position = new Vector3(0,0,transform.position.z);
				rb.velocity=new Vector2(0,0);
				Time.timeScale=0;
			}
		}
	}


