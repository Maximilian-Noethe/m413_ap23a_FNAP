using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent enemy;
    private bool mask = true; // Initialize mask as true
    public Transform Player;
    public bool Jumpscare = false;

    void Update()
    {
        // Check if "Q" button is pressed and toggle mask
        if (Jumpscare == false)
        {
            if (Input.GetButtonDown("Q"))
            {
                mask = !mask; // Toggle mask value
            }

            // If mask is false, set destination to the player's position
            if (mask == true)
            {
                enemy.SetDestination(Player.position);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Jumpscare = true;
        }
    }
}
