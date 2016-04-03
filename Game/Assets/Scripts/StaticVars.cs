using UnityEngine;
using System.Collections;

public class StaticVars : MonoBehaviour
{
	public static int score = 0;
	//public static float playerhealth = 1.0f;
	public static int lives = 3;
	public static bool paused = false;
	public static bool slowMotion = false;
	public static bool isInvincible = false;
	public static Vector3 newPosition;
	public static float moveInX;

	public enum weapons
	{
		Gun, Laser, Missle 
	}

	public static weapons CurrentWeapon = weapons.Gun;
}
