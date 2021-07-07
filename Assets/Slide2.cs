using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slide2 : MonoBehaviour
{
    DbGauge dbgauge;

    public GameObject a;

    string stage;

    Slider slHP;
    float timer = 0;
    float endtimer = 2.0f;
    public int addIndex = 2;
    // Start is called before the first frame update
    void Start()
    {
        stage = SceneManager.GetActiveScene().name;
        dbgauge = a.GetComponent<DbGauge>();
        slHP = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && dbgauge.flag == false)
        {
            slHP.value += addIndex;
        }

        if (slHP.value == 100)
        {
            SceneManager.LoadScene("Stage" + (int.Parse(stage.Substring(5)) + 1).ToString());
        }

        timer += Time.deltaTime;

        if (timer > endtimer)
        {
            slHP.value--;
            timer = 0;
        }


    }
}
