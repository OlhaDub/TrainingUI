using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ToggleLights : MonoBehaviour
{
    public List<GameObject> spotLights = new List<GameObject>();
    public List<GameObject> capsuleElements = new List<GameObject>();
    public bool active;

    public void OnButtonPress()
    {
        // «робити вс≥ Spotlights ≥ Capsules невидимими
        foreach (GameObject spotLight in spotLights)
        {
            spotLight.SetActive(active);
        }

        foreach (GameObject capsuleElement in capsuleElements)
        {
            capsuleElement.SetActive(active);
        }
    }
}

