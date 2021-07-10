using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    private AudioSource BGMSource;
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
        BGMSource = GetComponent<AudioSource>();
    }


    public void PlayMusic()
    {
        if (BGMSource.isPlaying) return;
        BGMSource.Play();
    }
    public void StopMusic()
    {
        BGMSource.Stop();
    }
}
