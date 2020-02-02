using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;

    public Animator animator;

    private void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(ObjectDialog dialogue)
    {

        animator.SetBool("IsOpen", true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string phrase = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(phrase));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene(2);

    }
}
