using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
	public string Level = "Level 1";

	public void Play()
	{
		Application.LoadLevel (Level);
		StaticVars.score = 0;
		StaticVars.lives = 3;
		StaticVars.paused = false;
		StaticVars.isInvincible = false;
	}
}
