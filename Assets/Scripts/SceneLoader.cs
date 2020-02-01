using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class SceneLoader : MonoBehaviour
{

    public string sceneName = null;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
