using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource BackgroundMusic;

    private bool isEnadle = true;
    public void Update()
    {
        if (isEnadle)
        {
            BackgroundMusic.enabled = true;
        }
        else
            BackgroundMusic.enabled = false;
    }
    public void EnableMusic()
    {
        if (isEnadle)
        {
            isEnadle = false;
        }
        else
            isEnadle = true;
    }
}
