using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomHand : MonoBehaviour
{
    public FingerPinch OnIndexPinch = new FingerPinch();
    public FingerPinch OnMiddlePinch = new FingerPinch();

    public OVRHand Hand { get; private set; } = null;

    private float time;
    private float timer;

    private void Awake()
    {
        Hand = GetComponent<OVRHand>();
        time = 2.0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (Hand.IsSystemGestureInProgress)
            return;
        
        if (timer >= time)
        {
            if (Hand.GetFingerIsPinching(OVRHand.HandFinger.Index))
            {
                OnIndexPinch.Invoke(this);
                timer = 0;
            }
                
        
            if (Hand.GetFingerIsPinching(OVRHand.HandFinger.Middle))
            {
                OnMiddlePinch.Invoke(this);
                timer = 0;
            }
        }
    }

    [Serializable]
    public class FingerPinch : UnityEvent<CustomHand> {}
}
