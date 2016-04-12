using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour 
{
	AudioSource audio;
	Animator anim;
	Rigidbody2D rb;

	public float meteorHealth;
	public int meteorPoints;
	public float rotationSpeed = 40;

	public GameObject score;
	public GameObject particles;


	void Start()
	{
		audio = GetComponent<AudioSource> ();
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();

		rb.AddTorque (Random.Range (-rotationSpeed, rotationSpeed));
	}

	public void CheckHealth()
	{
		if (meteorHealth <= 0) 
		{
			AudioSource.PlayClipAtPoint (audio.clip, transform.position, 3);
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
