using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
	//CharacterController character;
	Vector3 moveVector;
	public float speed;
	public float min;
	public float max;
	float playerDirection = 0;
		
	void Update ()
	{		
		if (StaticVars.playerhealth > 0)
		{
//			if (Input.touchCount > 0) 
//			{
//				Touch touch = Input.GetTouch (0);
//				if (touch.position.x < Screen.width / 2)
//					playerDirection = -1;
//				else if (touch.position.x > Screen.width / 2)
//					playerDirection = 1;
//
//				float moveInX = playerDirection * speed * Time.deltaTime;
//				Vector3 translateVector = new Vector3 (moveInX, 0, 0);	
//				Vector3 newPosition = transform.position + translateVector;
//
//
//				if (newPosition.x >= min && newPosition.x <= max)
//					transform.Translate (moveInX, 0, 0);	
//
//			}


			float moveInX = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
//			print (Input.GetAxis ("Horizontal"));

			Vector3 translateVector = new Vector3 (moveInX, 0, 0);	
				
			Vector3 newPosition = transform.position + translateVector;
				
				
			if (newPosition.x > min && newPosition.x < max)
				transform.Translate (moveInX, 0, 0);	
		}
	}
}