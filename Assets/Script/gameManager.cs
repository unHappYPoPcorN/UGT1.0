using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{


    void Update()
    {

    }
    public void startGame()
    {
        SceneManager.LoadScene("STAGE1");
    }

    public void goMainMenu()
    {
        SceneManager.LoadScene("main");
    }

    public void goSetting()
    {
        SceneManager.LoadScene("setting");
    }

    public void exitGame()
    {
        Application.Quit();
    }



}
