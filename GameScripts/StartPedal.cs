using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPedal : MonoBehaviour
{

    [SerializeField]
    private Timer timer;

    [SerializeField]
    private GameObject rollerBall;

    [SerializeField]
    private Transform startTarget;

    [SerializeField]
    private GameObject endGate;

    void Start()
    {
        // Point start gate towards end gate
        Vector3 egt = endGate.transform.position;
        // Ignore elevation changes by replacing the y position of the
        // end gate with teh y of the start gate.
        egt.y = transform.position.y;
        transform.LookAt(egt, transform.up);


        // Align roller ball with start gate postion
        rollerBall.transform.position = startTarget.position;
        rollerBall.transform.LookAt(egt, rollerBall.transform.up);
    }

    private void OnTriggerExit(Collider other)
    {
        timer.timerStart();
    }
}
