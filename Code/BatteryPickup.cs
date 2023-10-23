using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    public float batteryPower = 5.0f; // The amount of battery power to add to the flashlight.

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Find the Flashlightdrain component on the player and increase its intensity.
            Flashlightdrain flashlight = other.GetComponentInChildren<Flashlightdrain>();
            flashlight.IncreaseBatteryPower(batteryPower);

            // Deactivate the battery object.
            gameObject.SetActive(false);
        }
    }
}
