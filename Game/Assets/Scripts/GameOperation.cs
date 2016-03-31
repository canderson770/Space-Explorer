using UnityEngine;
using System.Collections;

public class GameOperation : MonoBehaviour
{
	public void Play()
	{
		Application.LoadLevel ("Level 1");
		StaticVars.score = 0;
		StaticVars.lives = 3;
		StaticVars.paused = false;
		StaticVars.isInvincible = false;
	}

	public void MainMenu()
	{
		Application.LoadLevel ("MainMenu");
	}

	public void CloseGame()
	{
		Application.Quit();	
	}
}
