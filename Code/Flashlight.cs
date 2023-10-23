using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;
    public bool on;
    public bool off;

    void Start()
    {
        off = true;
        flashlight.SetActive(false);
    }
    void Update()
    {
        if (off && Input.GetMouseButtonDown(0))
        {
            flashlight.SetActive(true);
            off = false;
            on = true;
        }
        else if (on && Input.GetMouseButtonDown(0))
        {
            flashlight.SetActive(false);
            off = true;
            on = false;
        }
    }
}