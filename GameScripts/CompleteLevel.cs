using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompleteLevel : MonoBehaviour {

    [SerializeField]
    private Timer timer;

    [Header("GUI References")]
    [SerializeField]
    private RectTransform HUDTimerPanel;

    [SerializeField]
    private RectTransform winPanel;
    [SerializeField]
    private Text winTimeText;


    private void OnTriggerEnter(Collider other)
    {
        showWinPanel();
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
