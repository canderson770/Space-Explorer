using UnityEngine;
using System.Collections;
using System;

public class AddObjects : MonoBehaviour 
{
	public static Action<GameObject> AddObjectsBack;
	Rigidbody2D rigidbody;

	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D> ();
	}

	void OnTriggerExit2D(Collider2D hit)
	{
		if (hit.gameObject.name == "floor")
		{
			if (AddObjectsBack != null) 
			{
				AddObjectsBack (this.gameObject);
			}

			rigidbody.isKinematic = true;

			this.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
