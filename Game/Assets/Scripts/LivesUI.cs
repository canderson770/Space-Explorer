using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LivesUI : MonoBehaviour
{
	public List<GameObject> livesArray;

	
	void Update ()
	{
		switch (StaticVars.lives) 
		{
		case 3: 
			for (int i = 0; i < livesArray.Count - 1; i++)
				livesArray [i].SetActive (true);
			break;
		case 2:
			livesArray [2].SetActive (false);
			break;
		case 1:
			livesArray [1].SetActive (false);
			break;
		case 0: 
			livesArray [0].SetActive (false);
			break;
		}
	}
}
