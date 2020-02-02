using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public Text play;
    public Text quit;
    public Animator transitionAnim;

    private void OnMouseOver()
    {
        Debug.Log("Sur le bouton");
        play.GetComponent<Animator>().enabled = true;
    }

    public void onClickPlay()
    {
        StartCoroutine(LoadSceneMenu(1, 5f));
        
    }

    public void onClickQuit()
    {
        Application.Quit();
    }

    IEnumerator LoadSceneMenu(int index, float _delay)
    {
        transitionAnim.enabled = true;
        yield return new WaitForSeconds(_delay);
        SceneManager.LoadScene(index);
    }
}
