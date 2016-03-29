using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
	public string Level = "Level 1";

	public void Play()
	{
		Application.LoadLevel (Level);
		StaticVars.score = 0;
		StaticVars.playerhealth = 1.0f;
		StaticVars.paused = false;
		StaticVars.isInvincible = false;
	}
}
