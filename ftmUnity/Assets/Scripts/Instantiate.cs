using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{
    public Transform trackingSpace; // reference to the tracking space
    //public OVRInput.Controller controller; // the controller to instantiate the object at
    public OVRHand hand;
    private MeshRenderer meshRenderer = null;
    public GameObject toInstantiate; // the game object to instantiate
    public Text text;

    private GameObject[] pillows;
    private float numPillows;

    public void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void InstantiateObject(CustomHand customHand)
    {
        //Vector3 position = trackingSpace.TransformPoint(OVRInput.GetLocalControllerPosition(controller));
        //Vector3 rotation = trackingSpace.TransformDirection(OVRInput.GetLocalControllerRotation(controller).eulerAngles);
   
        Vector3 position = trackingSpace.TransformPoint(hand.PointerPose.localPosition);
        //Vector3 rotation = trackingSpace.TransformDirection(hand.PointerPose.localRotation.eulerAngles);
        //text.text = position.ToString();

        Instantiate(toInstantiate, position, Quaternion.identity);
        // if (OVRInput.Get(OVRInput.Button.One))
        // {
        //     meshRenderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
        // }
    }

    public void ClearPillows(CustomHand customHand)
    {
        pillows = GameObject.FindGameObjectsWithTag("Pillow");
        numPillows = pillows.Length;

        for(int i = 0; i < numPillows; i++)
        {
            Destroy(pillows[i]);
        }

    }

    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Space))
    //     {
    //         Instantiate(toInstantiate, new Vector3(0, 0, 2.0f), Quaternion.identity);
    //         meshRenderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
    //     }
    // }
}
