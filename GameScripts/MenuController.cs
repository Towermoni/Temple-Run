using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField]
    private RectTransform mainMenu;

    [SerializeField]
    private RectTransform levelSelect;

    private void Start()
    {
        showMainMenu();
    }

    private void hidePanels()
    {
        mainMenu.gameObject.SetActive(false);
        levelSelect.gameObject.SetActive(false);
    }

    public void showMainMenu()
    {
        hidePanels();
        mainMenu.gameObject.SetActive(true);
    }

    public void showLevelSelectMenu()
    {
        hidePanels();
        levelSelect.gameObject.SetActive(true);
    }


}

