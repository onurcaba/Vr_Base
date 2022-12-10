using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    string currentSceneName;

    private void Start()
    {
         currentSceneName = SceneManager.GetActiveScene().name;
    }

    public void _ReloadScene()
    {
        SceneManager.LoadScene(currentSceneName);
    }
}
