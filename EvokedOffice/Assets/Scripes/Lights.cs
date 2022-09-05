using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
 
    [SerializeField] private Material myMaterial;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Color off = new Color(0.0849f, 0.0896f, 0.1132f, 1);
            Color offoff = new Color(0.06f, 0.06f, 0.06f, 1);
            myMaterial.color = off;
            myMaterial.SetColor("_EmissionColor", off);
            RenderSettings.ambientLight = offoff;
            Debug.Log("LightsOff");

        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Color on = new Color(0.775f, 0.806f, 0.904f, 1);
            myMaterial.color = on;;
            myMaterial.SetColor("_EmissionColor", on);
            RenderSettings.ambientLight = on;
            Debug.Log("LightsOn");
        }
    }
}
