using UnityEngine;
using System.Collections;

public class TimeControl : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (StaticVars.paused)
			Time.timeScale = 0;
		if (!StaticVars.paused)
			Time.timeScale = 1;
	}
}
