using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
	//CharacterController character;
	Vector3 moveVector;
	public float speed;
	public float min;
	public float max;
		
	void Update ()
	{		
		if (StaticVars.playerhealth > 0) 
		{
			float moveInX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
			Vector3 translateVector = new Vector3(moveInX, 0, 0);	

			Vector3 newPosition = transform.position + translateVector;


			if (newPosition.x >= min && newPosition.x <= max) 
			{
				transform.Translate(moveInX, 0, 0);	
			}
		}
	}
}