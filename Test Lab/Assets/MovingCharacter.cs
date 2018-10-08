using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCharacter : MonoBehaviour {

	float Speed = 2;
	Animator anim;

	public float rotSpeed = 90;

	// Use this for initialization
	void Start () {

		
			anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.D))
		{
			anim.SetInteger("condition", 1);
			transform.position += transform.forward * Speed * Time.deltaTime;

		}
		else if(Input.GetKey(KeyCode.A))
		{
			anim.SetInteger("condition", 1);
			transform.position -= transform.forward * Speed * Time.deltaTime;
		}
		else if (Input.GetKey(KeyCode.Mouse1))
		{
			anim.SetInteger("condition", 3);
		}
		else if(Input.GetKey(KeyCode.P))
		{
			anim.SetInteger("condition", 4);
		}
		else{
			anim.SetInteger("condition",0);
		}

	}
}
