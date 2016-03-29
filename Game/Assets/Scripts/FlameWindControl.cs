using UnityEngine;
using System.Collections;

public class FlameWindControl : MonoBehaviour
{
	WindZone wind;
	public float flamesTrail = 50;

	void Start ()
	{
		wind = GetComponent<WindZone> ();
	}
	
	void Update ()
	{
		if (StaticVars.moveInX > 0)
		{
			wind.windMain = StaticVars.moveInX * flamesTrail;
		}
		else if (StaticVars.moveInX < 0)
		{
			wind.windMain = StaticVars.moveInX * flamesTrail;
		}
		else if (StaticVars.moveInX == 0)
		{
			wind.windMain = 0;
		}
	}
}
