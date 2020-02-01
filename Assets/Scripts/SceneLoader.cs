using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName = null;
    public void Retry()
    {
        SceneManager.LoadScene(sceneName);
    }
}
