using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangerArray;
    private AudioSource audioSource;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMasterVolume();
    }

    void OnLevelWasLoaded (int level)
    {
        AudioClip thisLevelMusic = levelMusicChangerArray[level];
        Debug.Log("Playing clip: " + thisLevelMusic);
        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }
	
}
