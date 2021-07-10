using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subMenu : MonoBehaviour
{

    public GameObject esc;
    public GameObject setting;
    bool isEsc;
    // Start is called before the first frame update
    void Start()
    {
        isEsc = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isEsc = !isEsc;
        }

        if (isEsc)
        {
            esc.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!isEsc)
        {
            esc.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void backToGame()
    {
        isEsc = false;
    }

    public void subSetting()
    {
        setting.SetActive(true);
    }
    public void exitSetting()
    {
        setting.SetActive(false);
    }
}
