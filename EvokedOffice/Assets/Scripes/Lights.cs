using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Lights : MonoBehaviour
{
 
    [SerializeField] private Material myMaterial;

    [SerializeField] private float timeMultiplier;

    [SerializeField] private float startHour;

    public float LighsOFF;

    public float LighsON;

    [SerializeField] private TextMeshProUGUI timeText;

    bool sleepTime = false;

    private DateTime currentTime;


    void Start()
    {
        Color on = new Color(0.775f, 0.806f, 0.904f, 1);
        myMaterial.color = on; ;
        myMaterial.SetColor("_EmissionColor", on);
        RenderSettings.ambientLight = on;
        Debug.Log("LightsOn");
        sleepTime = false;

        currentTime = DateTime.Now.Date + TimeSpan.FromHours(startHour);
    }

    void Update()
    {
        UpdateTimeOfDay();
    }

    private void UpdateTimeOfDay()
    {
        currentTime = currentTime.AddSeconds(Time.deltaTime * timeMultiplier);

        if (timeText != null)
        {
            timeText.text = currentTime.ToString("HH:mm");
        }
        Debug.Log(timeText.text);

        if (currentTime.Hour == LighsOFF)
        {
            Color off = new Color(0.0849f, 0.0896f, 0.1132f, 1);
            Color offoff = new Color(0.06f, 0.06f, 0.06f, 1);
            myMaterial.color = off;
            myMaterial.SetColor("_EmissionColor", off);
            RenderSettings.ambientLight = offoff;
            Debug.Log("LightsOff");
            sleepTime = true;
        }

        if (currentTime.Hour == LighsON)
        {
            Color on = new Color(0.775f, 0.806f, 0.904f, 1);
            myMaterial.color = on; ;
            myMaterial.SetColor("_EmissionColor", on);
            RenderSettings.ambientLight = on;
            Debug.Log("LightsOn");
            sleepTime = false;
        }

        void OnTriggerStay(Collider collision)
        {
            if (collision.gameObject.CompareTag("Sleep"))
            {
                sleep();
            }
         
        }

        void sleep()
        {

            if (sleepTime == true && (Input.GetKeyDown(KeyCode.E)))
            {
              Color on = new Color(0.775f, 0.806f, 0.904f, 1);
              myMaterial.color = on; ;
              myMaterial.SetColor("_EmissionColor", on);
              RenderSettings.ambientLight = on;
              Debug.Log("LightsOn");
              sleepTime = false;

              currentTime = DateTime.Now.Date + TimeSpan.FromHours(startHour);
                
            }
        }
    }
}
