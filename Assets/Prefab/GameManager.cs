﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

bool gameHasEnded = false;

public float restartDelay = 1f;

public GameObject completeLevelUI;

public void Victory()
{
completeLevelUI.SetActive(true);

}
public void GameOver()
{
    if (gameHasEnded == false)
    {
    gameHasEnded = true;
    Debug.Log("Loser");
    Invoke("Restart", restartDelay);

    }
}
void Restart ()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}
