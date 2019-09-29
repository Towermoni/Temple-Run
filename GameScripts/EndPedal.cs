using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGate : MonoBehaviour
{

    [SerializeField]
    private Timer timer;

    [SerializeField]
    private Transform captureTarget;

    [SerializeField]
    private float captureForce;

    [SerializeField]
    private float floatForce;

    // GUI updates
    [Header("GUI References")]
    [SerializeField]
    private RectTransform HUDTimerPanel;

    [SerializeField]
    private RectTransform winPanel;
    [SerializeField]
    private Text winTimeText;


    // Check for references
    private void Start()
    {
        if (timer == null) { Debug.Log("End Gate: Timer Missing"); }
        if (HUDTimerPanel == null) { Debug.Log("End Gate: HUD Missing"); }
        if (winPanel == null) { Debug.Log("End Gate: Win Panel Missing"); }
        if (winTimeText == null) { Debug.Log("End Gate: Win Text Missing"); }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>())
        {
            if (timer != null)
            {
                timer.timerStop();
                Debug.Log("End Gate: Finish Time: " + timer.getTimerTime());
            }
            showWinPanel();
        }
    }

    private void showWinPanel()
    {
        if (!Cursor.visible)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (timer == null || HUDTimerPanel == null || winPanel == null || winTimeText == null)
        {
            Debug.Log("End Gate: Missing Reference");
            return;
        }

        HUDTimerPanel.gameObject.SetActive(false);
        winPanel.gameObject.SetActive(true);
        winTimeText.text = "" + Mathf.Round(timer.getTimerTime() * 1000) / 1000.0f;
    }
}
