using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {
	public Rigidbody2D rb;
	public KeyCode cima;
	public KeyCode baixo;
	public float velocidade;
	public bool indoCima;
	public bool indoBaixo;

	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(cima)){
			indoCima=true;
		} else {
			indoCima=false;
		}
		if (Input.GetKey(baixo)){
			indoBaixo=true;
		}else{
			indoBaixo=false;
		}
	}
	void FixedUpdate(){
		if (indoCima ==true){
			rb.velocity= new Vector2(0,velocidade);
		} else if (indoBaixo==true){
			rb.velocity=new Vector2(0,-velocidade);
		} else{
			rb.velocity=new Vector2(0,0);
		}
	}
}
