using UnityEngine;
using System.Collections;

public class Missile : Gun
{
//	public GameObject[] meteors;
//	GameObject closest;
//	float closestDist = 1000000f;

	public GameObject explosion;
	Vector3 explosionOffset;

	void Start()
	{
		damage = 5; 
		explosionOffset = new Vector3(0,1.5f,0);
		base.Start ();
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
			Vector3 explosionPos = transform.position + explosionOffset;
			Instantiate (explosion, explosionPos, Quaternion.identity);
			Destroy (this.gameObject);
		}
	}







	//FAILED ATTEMPT AT HEAT SEEKING MISSILE

//	void Update()
//	{
//		meteors = GameObject.FindGameObjectsWithTag ("Meteor");
//
//		foreach(GameObject meteor in meteors)
//		{
//			float dist = (transform.position - meteor.transform.position).sqrMagnitude;
//
//			if (dist < closestDist) 
//			{
//				closestDist = dist;
//				closest = meteor;
//			}
//
//		}

//		Vector2 LookAtPoint = new Vector2(closest.transform.position.x, closest.transform.position.y);
//		transform.LookAt(new Vector3(0,LookAtPoint.y,LookAtPoint.x));

//		Quaternion rotation = Quaternion.LookRotation (closest.transform.position - transform.position, transform.TransformDirection (Vector3.up));
//		transform.rotation = new Quaternion (0, 0, rotation.z, rotation.w);

//		// Calculate the direction from the current position to the target
//		Vector3 targetDirection = closest.transform.position - transform.position;
//		// Calculate the rotation required to point at the target
//		Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
//		// Rotate from the current rotation towards the target rotation, but not
//		// faster than mRotationSpeed degrees per second
//		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation,	30 * Time.deltaTime);
//		// Move forward
//		transform.position += transform.forward * 20 * Time.deltaTime;
//	}
}
