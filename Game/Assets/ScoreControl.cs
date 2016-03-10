using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
	public float scoreTime;
	public Text scoreText;
	public int score = 0;


	public void StartScore()
	{
		StartCoroutine (Score ());
	}
	
	IEnumerator Score()
	{
		print ("waiting");
		do 
		{
			yield return new WaitForSeconds (scoreTime);

			score += 1;
			scoreText.text = score.ToString().PadLeft(6, '0');

		} while (StaticVars.playerhealth > 0);
	}
}
