using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float Timer;
    public Text box;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        box = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        box.text = Timer.ToString();
    }
}
