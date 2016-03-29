using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerMovement : MonoBehaviour
{
	//CharacterController character;
	Vector3 moveVector;
	public float speed = 15;
	public float min = -9.8f;
	public float max = 9.8f;
	float playerDirection = 0;

	bool cantMove = true;

	void Start()
	{
		StartCoroutine (EnableMovement ());
	}

	IEnumerator EnableMovement()
	{
		yield return new WaitForSeconds (3);
		cantMove = false;
	}
		
	void Update ()
	{		
		if (StaticVars.playerhealth > 0 && cantMove == false)
		{
//			if (Input.touchCount > 0) 
//			{
//				Touch touch = Input.GetTouch (0);
//				if (touch.position.x < Screen.width / 2)
//					playerDirection = -1;
//				else if (touch.position.x > Screen.width / 2)
//					playerDirection = 1;
//
//				StaticVars.moveInX = playerDirection * speed * Time.deltaTime;
//				Vector3 translateVector = new Vector3 (StaticVars.moveInX, 0, 0);	
//				StaticVars.newPosition = transform.position + translateVector;
//
//
//				if (StaticVars.newPosition.x >= min && StaticVars.newPosition.x <= max)
//					transform.Translate (StaticVars.moveInX, 0, 0);	
//
//			}


			StaticVars.moveInX = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
//			print (Input.GetAxis ("Horizontal"));

			Vector3 translateVector = new Vector3 (StaticVars.moveInX, 0, 0);	
				
			StaticVars.newPosition = transform.position + translateVector;
				
				
			if (StaticVars.newPosition.x > min && StaticVars.newPosition.x < max)
				transform.Translate (StaticVars.moveInX, 0, 0);	
		}
	}
}