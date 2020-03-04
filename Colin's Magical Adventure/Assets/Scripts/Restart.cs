using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("Hi");
        SceneManager.LoadScene("Loading");
    }

    public void RestartToMenu()
    {
        Debug.Log("Hi");
        SceneManager.LoadScene("MenuScene");
    }
}
