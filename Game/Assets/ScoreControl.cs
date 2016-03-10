using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
	public float scoreTime;
	public Text scoreText;


	public void StartScore()
	{
		StartCoroutine (Score ());
	}
	
	IEnumerator Score()
	{
		do 
		{
			yield return new WaitForSeconds (scoreTime);

			StaticVars.score += 1;
			scoreText.text = StaticVars.score.ToString().PadLeft(6, '0');

		} while (StaticVars.playerhealth > 0);
	}
}
