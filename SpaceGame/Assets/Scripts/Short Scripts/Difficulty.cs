using UnityEngine;
using System.Collections;

public class Difficulty : MonoBehaviour
{
	public float spawnIncreaseRate = .1f;
	public int spawnIncreateTime = 60;
	float previousTime = 0;

	void Update ()
	{
		if(SpawnControl.spawnSeconds > spawnIncreaseRate)
			if (Time.timeSinceLevelLoad - previousTime > spawnIncreateTime)
			{
				SpawnControl.spawnSeconds -= spawnIncreaseRate;
				previousTime = Time.timeSinceLevelLoad;
				print (SpawnControl.spawnSeconds);
			}	
	}
}
