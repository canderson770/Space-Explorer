using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinalScore : MonoBehaviour
{
	Text finalScore;

	// Use this for initialization
	void Start ()
	{
		finalScore = GetComponent<Text> ();
		finalScore.text = StaticVars.score.ToString();
	}

}
