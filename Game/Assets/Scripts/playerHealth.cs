using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
	SpriteRenderer spriteRenderer;
	public float damage = .5f;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void OnCollisionEnter2D()
	{
		print ("hit");
		if (StaticVars.playerhealth > 0) 
		{
			StaticVars.playerhealth -= damage;
		}
		if (StaticVars.playerhealth <= 0) 
		{
			spriteRenderer.enabled = false;
			StaticVars.paused = true;
		}
	}


}
