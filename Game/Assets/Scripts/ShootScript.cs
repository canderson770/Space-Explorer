using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootScript : MonoBehaviour
{
	public List<GameObject> weaponList;

	void Start()
	{
		StartCoroutine (Shoot ());
	}

	IEnumerator Shoot()
	{
		yield return new WaitForSeconds (3);

		while (StaticVars.lives > 0) 
		{
			if(StaticVars.CurrentWeapon == StaticVars.weapons.Gun)
				Instantiate (weaponList [0], transform.position, Quaternion.identity);
			if(StaticVars.CurrentWeapon == StaticVars.weapons.Laser)
				Instantiate (weaponList [1], transform.position, Quaternion.identity);
			if(StaticVars.CurrentWeapon == StaticVars.weapons.Missle)
				Instantiate (weaponList [2], transform.position, Quaternion.identity);
			
			yield return new WaitForSeconds (StaticVars.fireRate);
		}
	}
}
