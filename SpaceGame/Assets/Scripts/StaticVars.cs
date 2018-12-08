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
    public static int tempScore;

    public enum weapons
    {
        Gun, Missle, Laser
    }

    public static weapons CurrentWeapon = weapons.Gun;

    public static void Reset()
    {
        score = 0;
        coins = 0;
        lives = 3;
        paused = false;
        slowMotion = false;
        isInvincible = false;
    }
}
