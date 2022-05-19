using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundFX : MonoBehaviour
{
    private AudioSource soundFX;

    [SerializeField]
    private AudioClip attackSound1, attackSound2, dieSound, danceSound, victorySound, defenceSound;

    void Awake()
    {
        soundFX = GetComponent<AudioSource>();
    }

    public void Attack1()
    {
        soundFX.clip = attackSound1;
        soundFX.loop = false;
        soundFX.Play();
    }
    public void Attack2()
    {
        soundFX.clip = attackSound2;
        soundFX.loop = false;
        soundFX.Play();
    }
    public void Die()
    {
        soundFX.clip = dieSound;
        soundFX.loop = false;
        soundFX.Play();
    }
    public void Dance()
    {
        soundFX.clip = danceSound;
        soundFX.loop = false;
        soundFX.Play();
    }
    public void Victory()
    {
        soundFX.clip = victorySound;
        soundFX.loop = false;
        soundFX.Play();
    }
    
    public void Defence()
    {
        soundFX.clip = defenceSound;
        soundFX.loop = false;
        soundFX.Play();
    }
}