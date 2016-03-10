using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
	public float damage = .5f;
	void OnCollisionEnter()
	{
		if (StaticVars.playerhealth > 0) 
		{
			StaticVars.playerhealth -= damage;
		}
		if (StaticVars.playerhealth <= 0) 
		{

		}
	}
}
