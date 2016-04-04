using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour 
{
	public float meteorHealth;
	AudioSource audio;
	SpriteRenderer spriteRenderer;
	CircleCollider2D collider;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();	
		audio = GetComponent<AudioSource> ();
		collider = GetComponent<CircleCollider2D> ();
	}

	public void CheckHealth()
	{
		if (meteorHealth <= 0) 
		{
			spriteRenderer.enabled = false;
			collider.enabled = false;
			audio.PlayOneShot (audio.clip, 1);
		}
		else
		{
			spriteRenderer.enabled = true;
			collider.enabled = true;
		}
	}
}
