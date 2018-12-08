using UnityEngine;
using System.Collections;

public class TimeControl : MonoBehaviour
{
    public float slowMotion = .3f;

    void Update()
    {
        if (StaticVars.paused)
            Time.timeScale = 0;
        else if (StaticVars.slowMotion)
            Time.timeScale = slowMotion;
        else
            Time.timeScale = 1;
    }
}
