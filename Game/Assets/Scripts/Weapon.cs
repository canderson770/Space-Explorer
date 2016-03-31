using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
	public float gunSpeed;
	Rigidbody2D rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() 
	{
		rb.AddForce(0, 1);
	}
}
