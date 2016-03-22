using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
	SpriteRenderer spriteRenderer;
	public float damage = .5f;
	public GameObject gameOver;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void OnTriggerEnter2D()
	{
			if (StaticVars.playerhealth > 0)
			{
				StaticVars.playerhealth -= damage;
			}

			if (StaticVars.playerhealth <= 0)
			{
				spriteRenderer.enabled = false;
				StaticVars.paused = true;
				gameOver.SetActive (true);
			}

	}


}
