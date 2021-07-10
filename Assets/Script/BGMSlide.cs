using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BGMSlide : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider slider;
    public Slider slider2;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("BGM", 1f);
        slider2.value = PlayerPrefs.GetFloat("SFX", 1f);
    }

    public void SetBGMLevel(float sliderValue)
    {
        mixer.SetFloat("BGM", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGM", sliderValue);
    }
    public void SetSFXLevel(float slider2Value)
    {
        mixer.SetFloat("SFX", Mathf.Log10(slider2Value) * 20);
        PlayerPrefs.SetFloat("SFX", slider2Value);
    }
}
