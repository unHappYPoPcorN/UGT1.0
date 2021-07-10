using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide : MonoBehaviour
{
    Slider slHP;
    float timer = 0;

    bool goright = true;

    float sectionL = 60.0f;
    float sectionR = 80.0f;

    // Start is called before the first frame update
    void Start()
    {
        slHP = GetComponent<Slider>();
        slHP.value = 50;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timer += Time.deltaTime;

        if (goright) slHP.value++;
        else slHP.value--;

        timer = 0;

        if (slHP.value == 100) goright = false;
        else if (slHP.value == 0) goright = true;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (slHP.value > sectionL && slHP.value < sectionR) Debug.Log("성공");
            else Debug.Log("실패");
        }
    }

}
