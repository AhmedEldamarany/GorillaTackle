using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    AudioSource source;
    [SerializeField] AudioClip[] clips;
     bool playBackgroundMusic =true;
    private static AudioPlayer audioPlayer;
    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (audioPlayer == null)
        {
            audioPlayer = this;
        }
        else
        {
            DestroyObject(audioPlayer.gameObject);
            audioPlayer = this;
        }
    }
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

   
    public void GameOver()
    {
        source.Stop();
        source.clip = clips[0];
        source.loop = false;
        source.Play();
    }
    public void initSoundTrack()
    {
        if (playBackgroundMusic)
        {
        source.clip = clips[1];
        source.loop = true;
        source.Play();
        source.playOnAwake = true;

        }
        else
        {
            source.Stop();
            source.playOnAwake = false;
        }
    }
    public void MuteBackgroundMusic()
    {
        playBackgroundMusic = !playBackgroundMusic;
        initSoundTrack();
    }
}
