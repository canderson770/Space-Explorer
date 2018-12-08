using UnityEngine;
using System.Collections;

public class SimulateDeltatTime : MonoBehaviour
{
    private float lastTime;
    private ParticleSystem ps;

    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Start()
    {
        lastTime = Time.realtimeSinceStartup;
    }

    void Update()
    {
        float deltaTime = Time.realtimeSinceStartup - lastTime;
        ps.Simulate(deltaTime, true, false);
        lastTime = Time.realtimeSinceStartup;
    }
}
