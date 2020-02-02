using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource past;
    public AudioSource futur;
    private AudioSource hurry;
    private bool wasHurry = false;

    void Start()
    {
        hurry = GetComponent<AudioSource>();
    }

    void Update()
    {
        float hurryTime = hurry.clip.length;
        bool isHurry = Timer.Instance.timeLeft < hurryTime;
        if (isHurry && !wasHurry)
        {
            // hurry just start
            hurry.Play();
            past.Pause();
            futur.Pause();
        }
        else if (!isHurry && wasHurry)
        {
            // hurry just stop
            hurry.Stop();
            past.UnPause();
            futur.UnPause();
        }
        wasHurry = isHurry;
    }
}
