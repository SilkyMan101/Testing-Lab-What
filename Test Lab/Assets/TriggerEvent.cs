using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

	public GameObject lightBulb = null;
	Animator anim;

	// Use this for initialization

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.name == "ToonRTS_demo_Knight")
		{
			anim.SetInteger("condition", 4);

		}
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider other) 
	{
		if( other.name == "ToonRTS_demo_Knight")
		{
			anim.SetInteger("condition", 1);
		}
	}
}
