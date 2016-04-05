using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MeteorScore : MeteorExplosion
{
	GameObject child;
	Text score;


	void Start()
	{
//		Meteor.PassMeteorPoints += SetScore;

		child = transform.Find ("Score").gameObject;
		score = child.GetComponent<Text> ();
		SetScore ();
		StartCoroutine (WaitForDestroy ());
	}

	void SetScore()
	{
		score.text = StaticVars.tempScore.ToString();
		StaticVars.score += StaticVars.tempScore;
	}

	IEnumerator WaitForDestroy()
	{
		yield return new WaitForSeconds (2);
		Destroy (this.gameObject);
	}
}
