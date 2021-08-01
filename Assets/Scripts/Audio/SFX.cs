using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    AudioSource source;
    [SerializeField] AudioClip[] clips;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.loop = false;
    }
public void GameOver()
    {
        source.clip = clips[2];
        source.Play();
    }
    public void HealingSfx()
    {
        source.clip = clips[0];
        source.Play();
    }public void InfectingSfx()
    {
        source.clip = clips[1];
        source.Play();
    }
}
