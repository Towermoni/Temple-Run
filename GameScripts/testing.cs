using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testing : MonoBehaviour
{
    /*
    [SerializeField] private Image customImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = false;
        }
    }
    */


    public bool isImgOn;
    [SerializeField] Image img;

    void Start()
    {

        img.enabled = true;
        isImgOn = true;
    }

    void Update()
    {

        if (Input.GetKeyDown("i"))
        {

            if (isImgOn == true)
            {

                img.enabled = false;
                isImgOn = false;
            }

            else
            {

                img.enabled = true;
                isImgOn = true;
            }
        }
    }
}
