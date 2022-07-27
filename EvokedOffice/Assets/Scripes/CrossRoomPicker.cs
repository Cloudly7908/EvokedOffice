using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossRoomPicker : MonoBehaviour
{
    public GameObject Side1;
    public GameObject Side2;
    public GameObject Side3;
    public GameObject Side4;

    public List<GameObject> plots;

    void Start()
    {
        Instantiate(plots[Random.Range(0, plots.Count)], Side1.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], Side2.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], Side3.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], Side4.transform);

    }
}
