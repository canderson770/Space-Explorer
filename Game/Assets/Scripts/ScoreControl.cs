using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
	public float scoreTime;
	public Text scoreText;
	public float RoundSeconds = 3;

	public void Start()
	{
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
