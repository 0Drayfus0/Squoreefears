using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public GameObject menuPanel;
    public bool menuActive;
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (menuActive)
            {
                Time.timeScale = 1f;
                menuActive = false;
                //audioManager.PlaySound(sndPauseActive);
            }
            else
            {
                Time.timeScale = 0f;
                menuActive = true;
                menuPanel.SetActive(true);
                //audioManager.PlaySound(sndPauseDeactivate);


            }

            menuPanel.SetActive(menuActive);
        }

    }
}
