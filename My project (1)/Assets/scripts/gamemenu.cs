using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemenu : MonoBehaviour
{
    public GameObject oyunu_durdur_pnl;
    public void tekrar_oyna()
    {
        SceneManager.LoadScene("Scenes/game");

        Time.timeScale = 1.0f;
    }


    public void devam_et()
    {
        oyunu_durdur_pnl.SetActive(false);
        Time.timeScale = 2.0f;
    }

    public void oyunu_durdur()
    {
        oyunu_durdur_pnl.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void NexttLevelButton()
    {
        Application.LoadLevel(1);
       // SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void NexttLeveButton()
    {
        Application.LoadLevel(2);
        // SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }


}
