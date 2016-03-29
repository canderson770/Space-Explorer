using UnityEngine;
using System.Collections;

public class FlameWindControl : MonoBehaviour
{
	WindZone wind;
	public float flamesTrail = 50;
	public float deadZone = 0.2f;

	void Start ()
	{
		wind = GetComponent<WindZone> ();
	}
	
	void Update ()
	{
		if (StaticVars.moveInX > deadZone)
		{
			wind.windMain = StaticVars.moveInX * flamesTrail;
		}
		else if (StaticVars.moveInX < -deadZone)
		{
			wind.windMain = StaticVars.moveInX * flamesTrail;
		}
		else if (StaticVars.moveInX < deadZone && StaticVars.moveInX > -deadZone)
		{
			wind.windMain = 0;
		}
	}
}
