﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPickup : MonoBehaviour
{
    public GameObject gameControllerInstance;
    public int points;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
    }
}
