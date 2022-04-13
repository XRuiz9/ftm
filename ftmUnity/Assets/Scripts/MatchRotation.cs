using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchRotation : MonoBehaviour
{
    public GameObject toMatch;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        toMatch = GameObject.FindGameObjectsWithTag("Center")[0];
        gameObject.tag = "Pillow";
    }

    void Update()
    {
        //transform.rotation = Quaternion.Euler(toMatch.transform.eulerAngles.x, toMatch.transform.eulerAngles.y, toMatch.transform.eulerAngles.z);
        transform.rotation = Quaternion.Euler(0, toMatch.transform.eulerAngles.y, 0);
    }
}
