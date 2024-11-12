using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActorSFX : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    private bool playSFX;

    public void PlaySFX(AudioClip clip)
    {
        _audioSource.PlayOneShot(clip);
    }

    public void ToogleSound(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            playSFX = !playSFX;
        }
        _audioSource.mute = playSFX;
    }
}
