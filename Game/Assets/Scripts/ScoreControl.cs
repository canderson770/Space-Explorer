using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
	Text scoreText;

	public float scoreTime;
	public float RoundSeconds = 3;

	public void Start()
	{
		scoreText = GetComponent<Text> ();

		StartCoroutine (Score ());
	}
	
	IEnumerator Score()
	{
		yield return new WaitForSeconds (RoundSeconds);
		do 
		{
			yield return new WaitForSeconds (scoreTime);

			StaticVars.score += 1;
			scoreText.text = StaticVars.score.ToString().PadLeft(6, '0');

		} while (StaticVars.lives > 0);
	}
}
