﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBridge : MonoBehaviour
{
    public GameObject bridge;
    public GameObject wall1;
    public GameObject wall2;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {   
        wall1.GetComponent<Collider>().enabled = false;
        wall2.GetComponent<Collider>().enabled = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter >= 2)
        {
            wall1.GetComponent<Collider>().enabled = true;
            wall2.GetComponent<Collider>().enabled = true;
            bridge.transform.Translate(0, -Time.deltaTime, 0, Space.World);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        counter = counter + 1;
    }

    void OnTriggerExit(Collider other)
    {
        counter = counter + 1;
    }
}