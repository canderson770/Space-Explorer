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
		if (StaticVars.lives <= 0)
			music.Stop ();
		if (StaticVars.slowMotion)
			music.pitch = .75f;
		else
			music.pitch = 1;
	}
}
