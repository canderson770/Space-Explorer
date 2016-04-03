using UnityEngine;
using System.Collections;

public class TimeControl : MonoBehaviour
{
	void Update ()
	{
		if (StaticVars.paused)
			Time.timeScale = 0;
		if (!StaticVars.paused)
			Time.timeScale = 1;
		if (StaticVars.slowMotion)
			Time.timeScale = .5f;
		if (!StaticVars.slowMotion)
			Time.timeScale = 1;
	}
}
