using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Material pinkMaterial = null;
    public Material tealMaterial = null;
    public Text text;

    private MeshRenderer meshRenderer = null;

    public void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetPink(CustomHand customHand)
    {
        meshRenderer.material = pinkMaterial;
        text.text = "Pink";

    }

    public void SetTeal(CustomHand customHand)
    {
        meshRenderer.material = tealMaterial;
        text.text = "Teal";
    }
}