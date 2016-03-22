using UnityEngine;
using System.Collections;
using System;

public class AddBaddies : MonoBehaviour 
{
	public static Action<GameObject> AddBaddiesBack;
	Rigidbody2D rigidbody;

	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D> ();
	}

	void OnTriggerExit2D(Collider2D hit)
	{
		if (hit.gameObject.name == "floor")
		{
			if (AddBaddiesBack != null) 
			{
				AddBaddiesBack (this.gameObject);
			}

			rigidbody.isKinematic = true;
		}
	}
}
