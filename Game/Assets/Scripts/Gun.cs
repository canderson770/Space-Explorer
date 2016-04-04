using UnityEngine;
using System.Collections;

public class Gun : Weapon 
{
	void Start()
	{
		bulletSpeed = 30;
		base.Start();
	}
}
