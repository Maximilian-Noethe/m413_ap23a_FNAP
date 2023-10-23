using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallremove : MonoBehaviour
{
    public int collectables;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (collectables == 3)
        {
            transform.position = new Vector3(-98.24857f, 100f, 90f);
        }
    }
}
