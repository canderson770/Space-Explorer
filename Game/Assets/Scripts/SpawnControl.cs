 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour
{
	public List<GameObject> baddies;
	public List<Transform> spawnPoints;

	public float spawnSeconds = .5f;
	public float rotationSpeed = 40;

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
		yield return new WaitForSeconds (3-spawnSeconds);

		while (StaticVars.lives > 0)
		{
			yield return new WaitForSeconds (spawnSeconds);
			if (baddies.Count > 0)
			{
				int random = Random.Range (0, baddies.Count - 1);

				int randomSpawnPointNum = Random.Range (0, spawnPoints.Count - 1);
				baddies [random].transform.position = spawnPoints [randomSpawnPointNum].position;

				Rigidbody2D rigidbody = baddies [random].GetComponent<Rigidbody2D> ();
				rigidbody.isKinematic = false;

				rigidbody.AddTorque (Random.Range (-rotationSpeed, rotationSpeed));

				baddies.RemoveAt (random);
			}
		}
	}

	void Update()
	{
		if (StaticVars.lives <= 0)
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