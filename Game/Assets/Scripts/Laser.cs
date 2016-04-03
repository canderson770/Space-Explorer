using UnityEngine;
using System.Collections;

public class Laser :  Weapon 
{
	void Update()
	{
		if (StaticVars.CurrentWeapon == StaticVars.weapons.Laser) 
		{
			print ("Laser");
			gunSpeed = 20;
			transform.localScale = new Vector2 (.1f, .7f);
		}
	}
}