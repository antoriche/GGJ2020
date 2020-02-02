using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public Text play;
    public Text quit;

    private void OnMouseOver()
    {
        Debug.Log("Sur le bouton");
        play.GetComponent<Animator>().enabled = true;
    }

    public void onClickPlay()
    {
        StartCoroutine(LoadSceneMenu("AntoninScene", 5f));
        StopCoroutine("LoadSceneMenu");
    }

    public void onClickQuit()
    {
        Application.Quit();
    }

    IEnumerator LoadSceneMenu(string _name, float _delay)
    {
        yield return new WaitForSeconds(_delay);
        SceneManager.LoadScene(_name);
    }
}
