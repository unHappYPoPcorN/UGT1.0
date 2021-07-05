using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide2 : MonoBehaviour
{
    DbGauge dbgauge;

    public GameObject a;

    Slider slHP;
    float timer = 0;
    float endtimer = 2.0f;
    public int addIndex = 2;
    // Start is called before the first frame update
    void Start()
    {
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

        timer += Time.deltaTime;

        if (timer > endtimer)
        {
            slHP.value--;
            timer = 0;
        }


    }
}
