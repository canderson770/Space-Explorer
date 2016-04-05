using UnityEngine;
using System.Collections;

public class StaticVars : MonoBehaviour
{
	public static int score = 0;
	public static int coins = 0;
	public static int lives = 3;
	public static bool paused = false;
	public static bool slowMotion = false;
	public static bool isInvincible = false;
	public static Vector3 newPosition;
	public static float moveInX;
	public static float fireRate = .75f;

	public static int tempScore;

	public enum weapons
	{
		Gun, Laser, Missle 
	}

	public static weapons CurrentWeapon = weapons.Gun;

	public static void Reset()
	{
		score = 0;
		lives = 3;
		paused = false;
		slowMotion = false;
		isInvincible = false;
		fireRate = .75f;
	}
}
