using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip gameOverMan;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    public AudioSource audioSrc;

    void Start()
    {
        gameOverMan = Resources.Load<AudioClip>("GameOverMan");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
       // audioSrc.PlayOneShot(gameOverMan);
    }

    public void HoverSound()
    {
        audioSrc.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        audioSrc.PlayOneShot(clickFx);
    }

}
