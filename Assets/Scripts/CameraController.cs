﻿using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
