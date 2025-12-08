using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private int currentScene;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void NextScene()
    {
        Debug.Log(currentScene);
        Debug.Log(SceneManager.GetSceneByBuildIndex(currentScene).name);
        SceneManager.LoadScene(currentScene+1);
    }
}
