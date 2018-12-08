using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour
{
    public List<GameObject> objects;
    public List<Transform> spawnPoints;

    public static float spawnSeconds = 1f;
    float timeSinceLastObj = 0;

    public float spawnIncreaseRate = .1f;
    public int spawnIncreateTime = 60;
    float previousTime = 0;

    void OnEnable()
    {
        SetAsSpawnPoint.PassSpawnPointTransform += AddToSpawnPointsList;
        spawnSeconds = 1f;
    }
    void OnDisable()
    {
        SetAsSpawnPoint.PassSpawnPointTransform -= AddToSpawnPointsList;
        spawnSeconds = 1f;
    }


    void Start()
    {
        spawnPoints = new List<Transform>();

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3);

        while (StaticVars.lives > 0)
        {
            if (objects.Count > 0)
            {
                int random = Random.Range(0, objects.Count);
                int randomSpawnPointNum = Random.Range(0, spawnPoints.Count);

                if (objects[random].name == "extraLife")
                {
                    if (Time.timeSinceLevelLoad < 30 || timeSinceLastObj < 5 || StaticVars.lives == 3)
                    {
                        timeSinceLastObj = 0;
                        continue;
                    }
                }

                if (objects[random].name == "stopwatch")
                {
                    if (Time.timeSinceLevelLoad < 45 || timeSinceLastObj < 20)
                    {
                        timeSinceLastObj = 0;
                        continue;
                    }
                }

                if (objects[random].name == "coin")
                {
                    if (Time.timeSinceLevelLoad < 5 || timeSinceLastObj < 2)
                    {
                        timeSinceLastObj = 0;
                        continue;
                    }
                }

                GameObject go = Instantiate(objects[random], spawnPoints[randomSpawnPointNum].position, Quaternion.identity) as GameObject;
            }

            yield return new WaitForSeconds(spawnSeconds);
        }

    }

    void Update()
    {
        if (StaticVars.lives <= 0)
            StopAllCoroutines();

        timeSinceLastObj += 1 * Time.deltaTime;

        if (spawnSeconds > spawnIncreaseRate)
            if (Time.timeSinceLevelLoad - previousTime > spawnIncreateTime)
            {
                spawnSeconds -= spawnIncreaseRate;
                previousTime = Time.timeSinceLevelLoad;
                print(spawnSeconds);
            }
    }

    void AddToSpawnPointsList(Transform _spawnPoint)
    {
        spawnPoints.Add(_spawnPoint);
    }

    void AddToObjectsList(GameObject _obj)
    {
        objects.Add(_obj);
    }
}
