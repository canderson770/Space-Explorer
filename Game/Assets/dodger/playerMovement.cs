using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
	Vector3 moveVector;
	public float speed;


	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);	
	}
}