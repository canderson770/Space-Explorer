using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
	SpriteRenderer spriteRenderer;
	CircleCollider2D playerCollider;
	Animator anim;
	AudioSource source;

	public AudioClip hitSound;
	public AudioClip deathSound;
	public AudioClip coinSound;

	public int coinValue = 100;
	public int damage = 1;
	public float invincibility = 1;
	public GameObject gameOver;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		playerCollider = GetComponent<CircleCollider2D> ();
		anim = GetComponent<Animator> ();
		source = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name == "meteor")
		{
			if (StaticVars.lives > 0 && StaticVars.isInvincible == false)
			{
				StaticVars.lives -= damage;
				StaticVars.isInvincible = true;

				if (StaticVars.lives > 0)
					source.PlayOneShot (hitSound);
				
				if (anim != null) 
				{
					anim.updateMode = AnimatorUpdateMode.UnscaledTime;
					anim.Play ("invincible");
				}
			
				StartCoroutine (StopInvincible ());
			}

			if (StaticVars.lives <= 0)
				Death ();
		} 

		else if (coll.gameObject.name == "coin") 
		{
			StaticVars.score += coinValue;
			coll.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			source.PlayOneShot (coinSound, 1);
		}

		else if (coll.gameObject.name == "extraLife") 
		{
			if(StaticVars.lives < 3)
				StaticVars.lives += 1;
			coll.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			source.PlayOneShot (coinSound, 1);
		}
	}

	void Death()
	{
		playerCollider.enabled = false;
		source.PlayOneShot(deathSound);
		if(anim != null)
		{
			anim.updateMode = AnimatorUpdateMode.UnscaledTime;
			anim.Play ("die");
		}
		StaticVars.paused = true;
		gameOver.SetActive (true);
	}

	IEnumerator StopInvincible()
	{
		yield return new WaitForSeconds (invincibility);
		StaticVars.isInvincible = false;
	}
}
