﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public Transform rockPoint;
    public GameObject rockPrefab;
    public double time;
    public double timer;

    // Start is called before the first frame update
    void Start()
    {
        time = 2;
        timer = time;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            rockSpawn();
            timer = time;
        }
    }
    public void rockSpawn()
    {
      Instantiate(rockPrefab, rockPoint.position, rockPoint.rotation);
    }
}
