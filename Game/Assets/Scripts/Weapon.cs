using UnityEngine;
using System.Collections;
using System;

public class Weapon : MonoBehaviour
{
	public float bulletSpeed = 10;
	public float damage = 1;
	Rigidbody2D rb;

	public void Start() 
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.up * bulletSpeed;
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name == "ceiling")
		{
			print ("destroy");
			DestroyObject (this.gameObject);
		}

		if (coll.gameObject.name == "meteor")
		{
			print ("hit");
			Meteor meteor = coll.gameObject.GetComponent<Meteor> ();
			meteor.meteorHealth -= damage;
			meteor.CheckHealth ();
		}
	}
}
