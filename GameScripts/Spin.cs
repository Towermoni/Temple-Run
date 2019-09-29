using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    [SerializeField]
    private float xSpinSpeed;

    [SerializeField]
    private float ySpinSpeed;

    [SerializeField]
    private float zSpinSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (zSpinSpeed != 0)
        {
            transform.Rotate(0f, 0f, zSpinSpeed * Time.deltaTime);
        }

        if (ySpinSpeed != 0)
        {
            transform.Rotate(0f, ySpinSpeed * Time.deltaTime, 0f);
        }

        if (xSpinSpeed != 0)
        {
            transform.Rotate(xSpinSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}