using UnityEngine;
using System.Collections;
using System;

public class AddBaddies : MonoBehaviour 
{
	public static Action<GameObject> AddBaddiesBack;

	void OnTriggerEnter2D(Collider2D hit) 
	{
		if (hit.gameObject.name == "bottomBorder")
		{
			if (AddBaddiesBack != null)
				AddBaddiesBack (this.gameObject);
		}
	}
}
