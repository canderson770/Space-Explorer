using UnityEngine;
using System.Collections;

public class MusicControl : MonoBehaviour
{
	AudioSource music;

	void Start()
	{
		music = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (StaticVars.playerhealth <= 0)
			music.Stop ();
	}
}
