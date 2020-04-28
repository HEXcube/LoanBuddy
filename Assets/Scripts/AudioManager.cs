using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public bool audioEnabled = true;
    public AudioSource ButtonTouchSound;

    public void ToggleAudio()
    {
        if (audioEnabled)
            audioEnabled = false;
        else audioEnabled = true;
    }

    public void ActivateAudio()
    {
        audioEnabled = true;
    }

    public void DeActivateAudio()
    {
        audioEnabled = false;
    }

    public void PlayButtonTouchSound()
    {
        if (audioEnabled)
            ButtonTouchSound.Play();
    }
}
