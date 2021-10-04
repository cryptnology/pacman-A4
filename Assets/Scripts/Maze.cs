using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public AudioClip intro;
    public AudioClip backgroundNormal;

    private bool playedIntro = false;
    private bool playedBackgroundNormal = false;

    private new AudioSource audio;

    float timer = 0.0f;
    int currentIntTimer = 0;

    void Start()
    {
        audio = transform.GetComponent<AudioSource>();

    }

    void Update()
    {
        timer += Time.deltaTime;
        currentIntTimer = (int)timer;
        PlayMusic();

    }

    void PlayMusic()
    {
        if (!playedIntro)
        {
            audio.PlayOneShot(intro);
            playedIntro = true;

        }
        if (currentIntTimer > 4 && !playedBackgroundNormal)
        {
            audio.PlayOneShot(backgroundNormal);
            playedBackgroundNormal = true;
        }

    }
}
