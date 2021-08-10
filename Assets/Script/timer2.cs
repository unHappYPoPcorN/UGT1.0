using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer2 : MonoBehaviour
{
    public Text TimeTxt;

    float Timer;
    Slider slTime;
    // Start is called before the first frame update
    void Start()
    {

        TimeTxt = GameObject.Find("Time").GetComponent<Text>();
        Timer = 0;
        slTime = GetComponent<Slider>();
        slTime.value = slTime.maxValue;
    }
    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime;
        slTime.value = slTime.maxValue - Timer;
        TimeTxt.text = "남은시간 : " + (100 - Timer).ToString();
    }
}