using UnityEngine;
using System.Collections;
using System;

public class Weapon : MonoBehaviour
{
	public static float gunSpeed;
	public static Action<GameObject> PassBullets;

	void Start() 
	{
		if (PassBullets != null)
			PassBullets (gameObject);
	}
}
