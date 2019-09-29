using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField]
    private Text timerGUIText;


    private float runningTime;
    private bool run;


    // Use this for initialization
    void Start()
    {
        runningTime = 0;
        run = true;
        timerGUIText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            runningTime += Time.deltaTime;
            timerGUIText.text = "" + Mathf.Round(runningTime * 100) / 100;
        }

    }

    public void timerStart()
    {
        run = true;
    }

    public void timerStop()
    {
        run = false;
    }

    public void timerReset()
    {
        runningTime = 0;
    }

    public float getTimerTime()
    {
        return runningTime;
    }
}
