using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DbGauge : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;

    public bool flag = false;

    Slider slDb;
    float timer = 0;
    float endtimer = 2.0f;

    float ftimer = 0;
    float fendtimer = 1.0f;

    int level = 0;
    public int addIndex = 2;
    // Start is called before the first frame update
    void Start()
    {
        slDb = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            ftimer += Time.deltaTime;
            if (fendtimer < ftimer)
            {
                flag = false;
                ftimer = 0;
            }
            //1 second after false;;
        }

        if (Input.GetKeyDown(KeyCode.A) && flag == false)
        {
            slDb.value += addIndex;
        }

        timer += Time.deltaTime;

        if (timer > endtimer)
        {
            slDb.value = slDb.value - 2;
            timer = 0;
        }

        if (slDb.value == 25)
        {
            flag = true;
            level++;
            slDb.value = 0;
        }

        if (level == 1)
        {
            level1.SetActive(true);
        }
        else if (level == 2)
        {
            level2.SetActive(true);
        }
        else if (level == 3)
        {
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }
}
