﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameScript gs;

	public float speed;
	// Use this for initialization
	void Start () {
		gs = GameObject.Find("GameManager").GetComponent<GameScript>();
	}
	
	void FixedUpdate() {
		InputManager();
	}	

	private void InputManager() 
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.left * speed;
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right * speed;
		}
		if(Input.GetMouseButtonDown(0))
		{
			//Interactua con objetos
		}
		if(Input.GetMouseButtonDown(1))
		{
			//algo
		}
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		gs.restarSanidad();
	}
	public void OnCollisionStay(Collision other)
	{
		
	}

}
