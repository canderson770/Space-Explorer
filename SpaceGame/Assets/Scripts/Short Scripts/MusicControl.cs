using UnityEngine;
using System.Collections.Generic;

public class MusicControl : MonoBehaviour
{
    public List<AudioSource> music;


    void Update()
    {
        if (StaticVars.lives <= 0)
        {
            foreach (AudioSource source in music)
            {
                source.Stop();
            }
        }
        if (StaticVars.slowMotion)
        {
            foreach (AudioSource source in music)
            {
                source.pitch = .7f;
            }
        }
        else
        {
            foreach (AudioSource source in music)
            {
                source.pitch = 1 + ((1 - SpawnControl.spawnSeconds) / 2);
            }
        }
    }
}
