using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioSource _audioSource;
    private bool playBgmSound;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBGM(AudioClip audio)
    {
        _audioSource.clip = audio;
        _audioSource.Play();
    }

    public void ToogleSound(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            playBgmSound = !playBgmSound;
        }
        _audioSource.mute = playBgmSound;
    }
}
