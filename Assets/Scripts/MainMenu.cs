using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

public void PlayGame()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

public void LeaveGame()

{
Application.Quit();
}

public void CreditsLoad()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
}



}
