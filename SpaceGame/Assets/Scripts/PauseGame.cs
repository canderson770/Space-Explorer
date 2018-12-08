using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
    private bool pauseGame = false;

    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            pauseGame = !pauseGame;
            StaticVars.paused = pauseGame;
            pauseMenu.SetActive(pauseGame);
        }
    }
}
