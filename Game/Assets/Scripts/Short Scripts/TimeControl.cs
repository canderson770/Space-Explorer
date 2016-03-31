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
	}
}
