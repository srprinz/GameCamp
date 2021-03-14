using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip pauseHoverFX;
    public AudioClip pauseClickFX;
    public AudioClip resumeHoverFX;
    public AudioClip resumeClickFX;
    public AudioClip quitClickFX;
    public AudioClip menuClickFX;

    public void pauseHoverSound()
    {
        myFX.PlayOneShot(pauseHoverFX);
    }

    public void pauseClickSound()
    {
        myFX.PlayOneShot(pauseClickFX);
    }

    public void resumeHoverSound()
    {
        myFX.PlayOneShot(resumeHoverFX);
    }

    public void resumeClickSound()
    {
        myFX.PlayOneShot(resumeClickFX);
    }

    public void quitClickSound()
    {
        myFX.PlayOneShot(quitClickFX);
    }

    public void menuClickSound()
    {
        myFX.PlayOneShot(menuClickFX);
    }
}