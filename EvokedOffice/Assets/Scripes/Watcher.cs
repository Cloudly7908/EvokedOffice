using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Watcher : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            follow();
        }

    }

    void follow()
    {
        enemy.SetDestination(Player.position);
        enemy.transform.LookAt(Player.position);
    }
}
