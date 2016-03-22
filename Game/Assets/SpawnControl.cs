using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour
{
	public List<GameObject> baddies;
	public List<Transform> spawnPoints;

	public float seconds;

	void Start()
	{
		spawnPoints = new List<Transform> ();
		baddies = new List<GameObject> ();

		SetAsSpawnPoint.PassSpawnPointTransform += AddToSpawnPointsList;
		//SetAsBaddie.PassBaddieGameObject += AddToBaddiesList;
		AddBaddies.AddBaddiesBack += AddToBaddiesList;

	}

	public void StartSpawn()
	{
			StartCoroutine (Spawn ());
	}

	IEnumerator Spawn()
	{
		while (StaticVars.playerhealth > 0)
		{
			yield return new WaitForSeconds (seconds);
			if (baddies.Count > 0)
			{
				int random = Random.Range (0, baddies.Count - 1);
				baddies [random].SetActive (true);

				int randomSpawnPointNum = Random.Range (0, spawnPoints.Count - 1);
				baddies [random].transform.position = spawnPoints [randomSpawnPointNum].position;


				baddies.RemoveAt (random);
			}
		}
	}

	void Update()
	{
		if (StaticVars.playerhealth <= 0)
			StopAllCoroutines ();
	}

	void AddToSpawnPointsList(Transform _spawnPoint)
	{
		spawnPoints.Add (_spawnPoint);
	}

	void AddToBaddiesList(GameObject _baddie)
	{
		baddies.Add (_baddie);
	}
}