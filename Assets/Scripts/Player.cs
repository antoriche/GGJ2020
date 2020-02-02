using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Singleton<Player>
{
    public void Die()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Scenes/deadScene");
    }
}
