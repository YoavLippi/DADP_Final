using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MusicController : MonoBehaviour
{
    public Slider volumeSlider; // Reference to your volume slider
    public AudioSource musicSource; // Reference to your audio source playing the music

    void Start()
    {
        // Assuming you have attached this script to the GameObject with the slider in the Inspector
        if (volumeSlider != null)
        {
            // Add a listener to the slider's value change event
            volumeSlider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    void ChangeVolume(float volume)
    {
        // Set the volume of the music source based on the slider value
        if (musicSource != null)
        {
            musicSource.volume = volume;
        }
    }
}
