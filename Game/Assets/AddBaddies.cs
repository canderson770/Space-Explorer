using UnityEngine;
using System.Collections;
using System;

public class AddBaddies : MonoBehaviour 
{
	public static Action<GameObject> AddBaddiesBack;

	void OnTriggerEnter () 
	{
		if (AddBaddiesBack != null)
			AddBaddiesBack (this.gameObject);
	}
}
