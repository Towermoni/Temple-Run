using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {


    [SerializeField]
    GameObject parentPanel;

    [SerializeField]
    int panelNumber;

    [SerializeField]
    GameObject gate;

    [SerializeField]
    

    GameObject childGate;
    bool isValid;

	// Use this for initialization
	void Start () {
        parentPanel = GameObject.Find("pedal" + panelNumber);
        childGate = parentPanel.transform.GetChild(0).gameObject;
        isValid = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        


	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player");
        {
            gate.setActive(false);
        }

    }
}
