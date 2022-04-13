using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject audiosources;
    private WombAudioQueue wombAudioQueueScript;

    private bool triggered;

    void Start()
    {
        wombAudioQueueScript = audiosources.GetComponent<WombAudioQueue>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            //Debug.Log("It works whore.");
            if (wombAudioQueueScript.loopBegan && !triggered)
            {
                wombAudioQueueScript.StopLoop();
                triggered = true;
            }
        }
        
    }
}
