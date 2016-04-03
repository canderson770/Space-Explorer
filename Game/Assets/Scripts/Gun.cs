using UnityEngine;
using System.Collections;

public class Gun : Weapon 
{
	void Update()
	{
		if (StaticVars.CurrentWeapon == StaticVars.weapons.Gun) 
		{
			print ("Gun");
			gunSpeed = 10;
			transform.localScale = new Vector2 (.1f, .1f);
		}
	}
}
