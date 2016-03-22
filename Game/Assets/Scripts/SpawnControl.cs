using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour
{
	public List<GameObject> baddies;
	public List<Transform> spawnPoints;

	public float seconds = .5f;
	public float RoundSeconds = 2.5f;

	void Start()
	{
		spawnPoints = new List<Transform> ();
		baddies = new List<GameObject> ();

		SetAsSpawnPoint.PassSpawnPointTransform += AddToSpawnPointsList;
		SetAsBaddie.PassBaddieGameObject += AddToBaddiesList;
		AddBaddies.AddBaddiesBack += AddToBaddiesList;

		StartCoroutine (Spawn ());

	}

	IEnumerator Spawn()
	{
		yield return new WaitForSeconds (RoundSeconds);
		while (StaticVars.playerhealth > 0)
		{
			yield return new WaitForSeconds (seconds);
			if (baddies.Count > 0)
			{
				int random = Random.Range (0, baddies.Count - 1);

				int randomSpawnPointNum = Random.Range (0, spawnPoints.Count - 1);
				baddies [random].transform.position = spawnPoints [randomSpawnPointNum].position;

				Rigidbody2D rigidbody = baddies [random].GetComponent<Rigidbody2D> ();
				rigidbody.isKinematic = false;

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