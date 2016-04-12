using UnityEngine;
using System.Collections;

public class Laser :  Gun 
{
	public override void Start()
	{
		bulletSpeed = 20;
		base.Start();
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
		}
	}

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Meteor")
		{
			Meteor meteor = coll.gameObject.GetComponent<Meteor> ();
			meteor.meteorHealth -= damage;
			meteor.CheckHealth ();
		}
	}
}