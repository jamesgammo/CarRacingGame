using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMainMenu : MonoBehaviour
{
    public static int panel;
    public GameObject SelectModePanel;
    public GameObject MainMenu;
    public GameObject LoginAndRegister;
    

    // Start is called before the first frame update
    public void Start()
    {
        if (DBManager.username != null)
        {
            SelectModePanel.SetActive(true);
            MainMenu.SetActive(false);
            LoginAndRegister.SetActive(false);
        }
    }
}
