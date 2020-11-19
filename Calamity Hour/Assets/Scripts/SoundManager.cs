using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip gameOverMan;
    static AudioSource audioSrc;

    void Start()
    {
        gameOverMan = Resources.Load<AudioClip>("GameOverMan");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
        audioSrc.PlayOneShot(gameOverMan);
    }
}
