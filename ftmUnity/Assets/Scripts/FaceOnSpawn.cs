using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceOnSpawn : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        transform.LookAt(target);
        gameObject.tag = "Pillow";
    }
}
