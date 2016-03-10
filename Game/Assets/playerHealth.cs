using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{

	void OnCollisionEnter()
	{
		if(StaticVars.playerhealth > 0)
			StaticVars.playerhealth -= .5f;
	}
}
