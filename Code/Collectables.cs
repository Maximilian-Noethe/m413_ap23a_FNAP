using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Use TextMesh Pro
using UnityEngine.AI;

public class Collectables : MonoBehaviour
{
    public GameObject wall;
    public GameObject door;
    public int collectables;
    public int keys;
    public NavMeshAgent enemy;
    public Transform Player;
    public TextMeshProUGUI collectablesText; // Reference to the TextMeshProUGUI component.

    void Start()
    {
        // Initialize the collectables text with the initial value.
        UpdateCollectablesText();
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Collectables")
        {
            Debug.Log("Collectable collected");
            collectables = collectables + 1;
            Col.gameObject.SetActive(false);

            // Update the collectables text when a collectable is collected.
            UpdateCollectablesText();
        }
        else if (Col.gameObject.tag == "Key")
        {
            Debug.Log("Key collected");
            keys += 1; // Increment the keys count by 1 when a key is collected
            Col.gameObject.SetActive(false);
        }
    }

    void UpdateCollectablesText()
    {
        // Update the TextMeshProUGUI component with the current number of collectables.
        if (collectablesText != null)
        {
            collectablesText.text = "" + collectables.ToString();
        }
    }

    void Update()
    {
        if (collectables == 7)
        {
            wall.SetActive(false);
        }
        else
        {
            wall.SetActive(true);
        }
        if (keys == 1)
        {
            door.SetActive(false);
            enemy.SetDestination(Player.position);
        }
        else
        {
            door.SetActive(true);
        }
    }
}
