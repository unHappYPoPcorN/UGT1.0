using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer2 : MonoBehaviour
{
    float Timer;
    Slider slTime;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        slTime = GetComponent<Slider>();
        slTime.value = slTime.maxValue;
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        slTime.value = slTime.maxValue - Timer;
    }
}