using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
	public string Level = "Level 1";

	public void Play()
	{
		Application.LoadLevel (Level);	
	}
}
