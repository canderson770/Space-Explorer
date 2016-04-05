 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour
{
	public List<GameObject> objects;
	public List<Transform> spawnPoints;

	public float spawnSeconds = .7f;
	public float rotationSpeed = 40;
	float timeSinceLastObj = 0;

	void Start()
	{
		spawnPoints = new List<Transform> ();
//		objects = new List<GameObject> ();

		SetAsSpawnPoint.PassSpawnPointTransform += AddToSpawnPointsList;
//		SetAsObject.PassObjectGameObject += AddToObjectsList;
//		AddObjects.AddObjectsBack += AddToObjectsList;

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
					if (Time.timeSinceLevelLoad < 30 || timeSinceLastObj < 5 || StaticVars.lives == 3)
						continue;
					timeSinceLastObj = 0;
				}
				if(objects[random].name == "stopwatch")
				{
					if (Time.timeSinceLevelLoad < 45 || timeSinceLastObj < 30)
						continue;
					timeSinceLastObj = 0;
				}
				if(objects[random].name == "coin")
				{
					if (Time.timeSinceLevelLoad < 5 || timeSinceLastObj < 1)
						continue;
					timeSinceLastObj = 0;
				}

				Instantiate (objects [random], spawnPoints [randomSpawnPointNum].position, Quaternion.identity);

				Rigidbody2D thisRigidbody = objects [random].GetComponent<Rigidbody2D> ();
				thisRigidbody.isKinematic = false;

				thisRigidbody.AddTorque (Random.Range (-rotationSpeed, rotationSpeed));
			}
			yield return new WaitForSeconds (spawnSeconds);
		}

	}

	void Update()
	{
		if (StaticVars.lives <= 0)
			StopAllCoroutines ();

		timeSinceLastObj += 1 * Time.deltaTime;
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