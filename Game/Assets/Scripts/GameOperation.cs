using UnityEngine;
using System.Collections;

public class GameOperation : MonoBehaviour
{
	public void Play()
	{
		Application.LoadLevel ("Level 1");
		StaticVars.Reset ();
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
