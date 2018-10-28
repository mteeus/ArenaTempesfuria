using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pontuacao : MonoBehaviour {
	public static int pontos1;
	public static int pontos2;

	public Text Score1;
	public Text Score2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Score1.text = pontos1.ToString();
		Score2.text = pontos2.ToString();
	}
}
