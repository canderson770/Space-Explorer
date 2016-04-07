using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {


	private ShowPanels showPanels;						//Reference to the ShowPanels script used to hide and show UI panels
	private bool isPaused;								//Boolean to check if the game is paused or not
	private StartOptions startScript;					//Reference to the StartButton script
	
	//Awake is called before Start()
	void Awake()
	{
		//Get a component reference to ShowPanels attached to this object, store in showPanels variable
		showPanels = GetComponent<ShowPanels> ();
		//Get a component reference to StartButton attached to this object, store in startScript variable
		startScript = GetComponent<StartOptions> ();
	}

	// Update is called once per frame
	void Update () {

		//Check if the Cancel button in Input Manager is down this frame (default is Escape key) and that game is not paused, and that we're not in main menu
		if (Input.GetButtonDown ("Cancel") && !isPaused && !startScript.inMainMenu) 
		{
			//Call the DoPause function to pause the game
			DoPause();
		} 
		//If the button is pressed and the game is paused and not in main menu
		else if (Input.GetButtonDown ("Cancel") && isPaused && !startScript.inMainMenu) 
		{
			UnPause ();
		}
	
	}


	public void DoPause()
	{
		isPaused = true;
		Time.timeScale = 0;
		showPanels.ShowPausePanel ();
	}


	public void UnPause()
	{
		isPaused = false;
		Time.timeScale = 1;
		showPanels.HidePausePanel ();
	}


}
