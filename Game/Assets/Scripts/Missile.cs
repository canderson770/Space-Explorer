using UnityEngine;
using System.Collections;

public class Missile : Gun
{
	public GameObject explosion;
	Vector3 explosionOffset;

	void Start()
	{
		damage = 5; 
		explosionOffset = new Vector3(0,1.5f,0);
		base.Start ();
	}

	public override void OnTriggerEnter2D(Collider2D coll)
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
			Vector3 explosionPos = transform.position + explosionOffset;
			Instantiate (explosion, explosionPos, Quaternion.identity);
			Destroy (this.gameObject);
		}
	}
}		