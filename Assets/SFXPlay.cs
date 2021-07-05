using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlay : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource SFXSource;
    private GameObject[] musics;

    // Start is called before the first frame update
    void Awake()
    {
        musics = GameObject.FindGameObjectsWithTag("Music");

        if (musics.Length >= 2)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);
        SFXSource = GetComponent<AudioSource>();
    }


    public void PlayMusic()
    {
        if (SFXSource.isPlaying) return;
        SFXSource.Play();
    }
    public void StopMusic()
    {
        SFXSource.Stop();
    }
}
