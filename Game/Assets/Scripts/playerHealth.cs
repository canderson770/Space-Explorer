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

	public float damage = .5f;
	public float invincibility = 1;
	public GameObject gameOver;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		playerCollider = GetComponent<CircleCollider2D> ();
		anim = GetComponent<Animator> ();
		source = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D()
	{
		if (StaticVars.playerhealth > 0 && StaticVars.isInvincible == false)
			{
				StaticVars.playerhealth -= damage;
				StaticVars.isInvincible = true;
				if(StaticVars.playerhealth > 0)
					source.PlayOneShot(hitSound);
				if(anim != null)
				{
					anim.updateMode = AnimatorUpdateMode.UnscaledTime;
					anim.Play ("invincible");
				}
				StartCoroutine (StopInvincible ());
			}
			
		if (StaticVars.playerhealth <= 0)
			Death ();
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
