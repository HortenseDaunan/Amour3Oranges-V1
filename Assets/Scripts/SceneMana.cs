using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMana : MonoBehaviour
{
    public string nomScene;
    
    public void changeScene(string nomSceneFunc)
    {
        SceneManager.LoadScene(nomSceneFunc);

    }

     // CARROTTE AIME MATHIS
    void Start()
    {
        
    }
}