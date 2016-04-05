using UnityEngine;
using System.Collections;
using System;

public class Meteor : MonoBehaviour 
{
	AudioSource audio;
	Animator anim;

	public float meteorHealth;
	public int meteorPoints;
	public GameObject score;
	public GameObject particles;

	void Start()
	{
		audio = GetComponent<AudioSource> ();
		anim = GetComponent<Animator> ();
	}

	public void CheckHealth()
	{
		if (meteorHealth <= 0) 
		{
			AudioSource.PlayClipAtPoint (audio.clip, transform.position, 2);
			Instantiate (particles, transform.position, Quaternion.identity);

			StaticVars.tempScore = meteorPoints;
			Instantiate (score, transform.position, Quaternion.identity);
			
			Destroy (this.gameObject);
		} 
		else
			if(anim)
				anim.Play ("meteor_hit");
	}
}
