using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] private AudioClip bgmMusic;

    private AudioManager audioMan;

    void Start()
    {
        audioMan = FindObjectOfType<AudioManager>();
        audioMan.PlayBGM(bgmMusic);
    }
}
