using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MeteorScore : WaitForDestroyScript
{
	GameObject child;
	Text score;


	void Start()
	{
		child = transform.Find ("Score").gameObject;
		score = child.GetComponent<Text> ();
		SetScore ();
		base.Start ();
	}

	void SetScore()
	{
		score.text = StaticVars.tempScore.ToString();
		StaticVars.score += StaticVars.tempScore;
	}
}
