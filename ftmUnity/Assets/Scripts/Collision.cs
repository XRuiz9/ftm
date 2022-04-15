using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Collision : MonoBehaviour
{
    public AudioSource heartLoop;
    public GameObject timeline;
    private PlayableDirector director;

    //private WombAudioQueue wombAudioQueueScript;

   // private bool triggered;
    void Awake()
    {
        director = timeline.GetComponent<PlayableDirector>();
    }

    // void Start()
    // {
    //     wombAudioQueueScript = audiosources.GetComponent<WombAudioQueue>();
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            //Debug.Log("It works whore.");
            heartLoop.Stop();
            director.Play();
            // if (wombAudioQueueScript.loopBegan && !triggered)
            // {
            //     wombAudioQueueScript.StopLoop();
            //     triggered = true;
            // }
        }
        
    }
}
