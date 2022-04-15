using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WombControls : MonoBehaviour
{
    public GameObject center;
    public GameObject wombPrefab;
    //public GameObject wombLight;

    //private Animator lightAnimator;
    private GameObject currentWomb;
    // Start is called before the first frame update
    void Start()
    {
        OVRManager.HMDMounted += ResetWomb;
        currentWomb = GameObject.FindWithTag("Womb");
        //lightAnimator = wombLight.GetComponent<Animator>();
        //lightAnimator.keepAnimatorControllerStateOnDisable = true;
    }

    // public void SpawnWomb()
    // {
    //     Instantiate(wombPrefab, center.transform.position, Quaternion.identity);
    //     currentWomb = GameObject.FindWithTag("Womb");
    // }

    public void ResetWomb()
    {
        currentWomb.transform.position = center.transform.position;
    }

    // public void DestroyWomb()
    // {
    //     Destroy(currentWomb);
    // }
}
