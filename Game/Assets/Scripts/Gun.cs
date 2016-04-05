using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public float bulletSpeed = 30;
	public float damage = 1;
	public Rigidbody2D rb;

	public void Start() 
	{
		rb = GetComponent<Rigidbody2D> ();

		if (StaticVars.slowMotion)
			bulletSpeed = bulletSpeed * 2;

		rb.velocity = transform.up * bulletSpeed;
	}

	public virtual void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name == "ceiling")
		{
			DestroyObject (this.gameObject);
		}

		if (coll.gameObject.tag == "Meteor")
		{
			Meteor meteor = coll.gameObject.GetComponent<Meteor> ();
			meteor.meteorHealth -= damage;
			meteor.CheckHealth ();
			Destroy (this.gameObject);
		}
	}
}
