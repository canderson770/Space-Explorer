using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootScript : MonoBehaviour
{
	public List<GameObject> bullets;

	void Start()
	{
		bullets = new List<GameObject> ();
		Weapon.PassBullets += AddBullets;

		StartCoroutine (Shoot ());
	}
		

	IEnumerator Shoot()
	{
		yield return new WaitForSeconds (3.1f);
		bullets [0].transform.position = transform.position;
		bullets[0].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

		yield return new WaitForSeconds (.5f);
		StaticVars.CurrentWeapon = StaticVars.weapons.Laser;
		bullets [1].transform.position = transform.position;
		bullets[1].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

		yield return new WaitForSeconds (.5f);
		StaticVars.CurrentWeapon = StaticVars.weapons.Laser;
		bullets [2].transform.position = transform.position;
		bullets[2].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
	}



	void AddBullets(GameObject _bullet)
	{
		bullets.Add (_bullet);
	}
}
