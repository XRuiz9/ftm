using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WombAudioQueue : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource opening;
    public AudioSource heartLoop;
    public AudioSource ending;

    private bool introEnded;
    public bool loopBegan;

    void FixedUpdate()
    {
        if (!intro.isPlaying && !introEnded)
        {
            opening.Play();
            introEnded = true;
        }

        if (!loopBegan)
        {
            if (!opening.isPlaying && introEnded)
            {
                Debug.Log("We see each other.");
                heartLoop.Play();
                loopBegan = true;
            }
        }
    }

    public void StopLoop()
    {
        heartLoop.Stop();
        ending.Play();
    }
}
