using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public GameObject mask;

    public bool on;
    public bool off;




    void Start()
    {
        off = true;
        mask.SetActive(false);
    }




    void Update()
    {
        if (off && Input.GetButtonDown("Q"))
        {
            mask.SetActive(true);
            off = false;
            on = true;
        }
        else if (on && Input.GetButtonDown("Q"))
        {
            mask.SetActive(false);
            off = true;
            on = false;
        }



    }
}