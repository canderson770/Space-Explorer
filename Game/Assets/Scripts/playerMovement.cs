using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Boundary : System.Object
{
	public float min = -9.8f;
	public float max = 9.8f;
}

public class playerMovement : MonoBehaviour
{
	Vector3 moveVector;

	public float speed = 15;
	public Boundary boundary;

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
		
	void Update()
	{
		if (Input.GetKey (KeyCode.Keypad1))
		{
			StaticVars.CurrentWeapon = StaticVars.weapons.Gun;
			StaticVars.fireRate = .5f;
			print ("gun");
		}
		if (Input.GetKey (KeyCode.Keypad2)) 
		{
			StaticVars.CurrentWeapon = StaticVars.weapons.Laser;
			StaticVars.fireRate = 1;
			print ("laser");
		}
		if (Input.GetKey (KeyCode.Keypad3)) 
		{
			StaticVars.CurrentWeapon = StaticVars.weapons.Missle;
			StaticVars.fireRate = 2;
			print ("missile");
		}
	}

	void FixedUpdate ()
	{		
		if (StaticVars.slowMotion)
			speed = 30;
		if (!StaticVars.slowMotion)
			speed = 15;
		if (StaticVars.lives > 0 && cantMove == false)
		{
			if (Input.touchCount > 0) 
			{
				Touch touch = Input.GetTouch (0);
				if (touch.position.x < Screen.width / 2)
					playerDirection = -1;
				else if (touch.position.x > Screen.width / 2)
					playerDirection = 1;

				StaticVars.moveInX = playerDirection * speed/2 * Time.deltaTime;
				Vector3 translateVector = new Vector3 (StaticVars.moveInX, 0, 0);	
				StaticVars.newPosition = transform.position + translateVector;


				if (StaticVars.newPosition.x >= boundary.min && StaticVars.newPosition.x <= boundary.max)
					transform.Translate (StaticVars.moveInX, 0, 0);	

			} 

			else
			{
				StaticVars.moveInX = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

				Vector3 translateVector = new Vector3 (StaticVars.moveInX, 0, 0);	
				StaticVars.newPosition = transform.position + translateVector;

				if (StaticVars.newPosition.x >= boundary.min && StaticVars.newPosition.x <= boundary.max)
					transform.Translate (StaticVars.moveInX, 0, 0);
			}
		}
	}
}