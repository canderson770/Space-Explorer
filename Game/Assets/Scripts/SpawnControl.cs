 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour
{
	public List<GameObject> objects;
	public List<Transform> spawnPoints;

	public float spawnSeconds = .7f;
	public float rotationSpeed = 40;
	public float lifeSpawnSeconds = 30;
	float timeSinceLastLife = 0;

	void Start()
	{
		spawnPoints = new List<Transform> ();
		objects = new List<GameObject> ();

		SetAsSpawnPoint.PassSpawnPointTransform += AddToSpawnPointsList;
		SetAsObject.PassObjectGameObject += AddToObjectsList;
		AddObjects.AddObjectsBack += AddToObjectsList;

		StartCoroutine (Spawn ());

	}

	IEnumerator Spawn()
	{
		yield return new WaitForSeconds (3);

		while (StaticVars.lives > 0)
		{
			if (objects.Count > 0) 
			{
				int random = Random.Range (0, objects.Count - 1);
				int randomSpawnPointNum = Random.Range (0, spawnPoints.Count - 1);

				if(objects[random].name == "extraLife")
				{
					if (Time.timeSinceLevelLoad < lifeSpawnSeconds || timeSinceLastLife < 5)
						continue;
					timeSinceLastLife = 0;
				}
					
				objects [random].transform.position = spawnPoints [randomSpawnPointNum].position;

				Rigidbody2D thisRigidbody = objects [random].GetComponent<Rigidbody2D> ();
				thisRigidbody.isKinematic = false;

				thisRigidbody.AddTorque (Random.Range (-rotationSpeed, rotationSpeed));

				objects.RemoveAt (random);
			}
			yield return new WaitForSeconds (spawnSeconds);
		}

	}

	void Update()
	{
		if (StaticVars.lives <= 0)
			StopAllCoroutines ();

		timeSinceLastLife += 1 * Time.deltaTime;
	}

	void AddToSpawnPointsList(Transform _spawnPoint)
	{
		spawnPoints.Add (_spawnPoint);
	}

	void AddToObjectsList(GameObject _obj)
	{
		objects.Add (_obj);
	}
}