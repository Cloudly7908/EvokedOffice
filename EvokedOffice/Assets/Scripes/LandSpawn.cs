using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSpawn : MonoBehaviour
{
    public GameObject SpawnP1;
    public GameObject SpawnP2;
    public GameObject SpawnP3;
    public GameObject SpawnP4;
    public GameObject SpawnP5;
    public GameObject SpawnP6;
    public GameObject SpawnP7;
    public GameObject SpawnP8;
    public GameObject SpawnP9;

    public List<GameObject> plots;

    void Start()
    {
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP1.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP2.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP3.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP4.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP5.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP6.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP7.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP8.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP9.transform);
    }

   
}
