using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPicker : MonoBehaviour
{

    public GameObject Room;

    public List<GameObject> plots;

    void Start()
    {
        Instantiate(plots[Random.Range(0, plots.Count)], Room.transform);
        
    }
}
