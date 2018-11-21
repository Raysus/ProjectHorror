using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
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
	}

}
