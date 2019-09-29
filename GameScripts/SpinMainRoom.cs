using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMainRoom : MonoBehaviour {

    [SerializeField]
    private float speed;


    bool playOnStart;
    // Use this for initialization
    void Start()
    {
        playOnStart = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (playOnStart == true)
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speed), Space.Self);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        playOnStart = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playOnStart = false;
    }
}
