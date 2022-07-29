using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SecurityBot : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            follow();
            Debug.Log("following");
        }

    }

    void follow()
    {
        enemy.SetDestination(Player.position);
    }

    void Update()
    {
        enemy.SetDestination(Player.position);
    }



}
