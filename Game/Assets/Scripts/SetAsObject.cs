using UnityEngine;
using System.Collections;
using System;

public class SetAsObject : MonoBehaviour 
{
	public static Action<GameObject> PassObjectGameObject;
	
	void Start () 
	{
		if (PassObjectGameObject != null)
			PassObjectGameObject (this.gameObject);
	}
	
}