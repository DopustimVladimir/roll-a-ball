using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladesController : MonoBehaviour
{
    public float rotationSpeed = 50f;

    private Vector3 rotation;

    void Start()
    {
        rotation = new Vector3(180, 0, 0);
    }

    void Update()
    {
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
