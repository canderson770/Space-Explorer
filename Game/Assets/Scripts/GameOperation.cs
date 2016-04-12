using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOperation : MonoBehaviour
{
	public void Play()
	{
		SceneManager.LoadScene ("Level 1");
		StaticVars.Reset ();
	}

	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void CloseGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif

		Application.Quit();
	}
}
	