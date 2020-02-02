using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClipBoard : Actionnable
{
    // Start is called before the first frame update
    public override void OnAction()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Scenes/victoryEnd");
    }
}
