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
			for (int i = 0; i < livesArray.Count; i++)
				livesArray [i].SetActive (true);
			break;
		case 2:
			livesArray [2].SetActive (false);
			livesArray [1].SetActive (true);
			livesArray [0].SetActive (true);
			break;
		case 1:
			livesArray [2].SetActive (false);
			livesArray [1].SetActive (false);
			livesArray [0].SetActive (true);
			break;
		case 0: 
			for (int i = 0; i < livesArray.Count; i++)
				livesArray [i].SetActive (false);
			break;
		}
	}
}
