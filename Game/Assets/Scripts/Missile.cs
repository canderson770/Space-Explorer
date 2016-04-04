using UnityEngine;
using System.Collections;

public class Missile : Weapon
{
	void Start()
	{
		bulletSpeed = 10;
		damage = 3;
		base.Start();
	}
}
