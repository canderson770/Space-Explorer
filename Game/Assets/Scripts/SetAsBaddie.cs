using UnityEngine;
using System.Collections;
using System;

public class SetAsBaddie : MonoBehaviour 
{
	public static Action<GameObject> PassBaddieGameObject;
	
	void Start () 
	{
		if (PassBaddieGameObject != null)
			PassBaddieGameObject (this.gameObject);
	}
	
}