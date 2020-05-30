using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
// Script tomado de https://www.youtube.com/watch?v=9ROolmPSC70
public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPLay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;




    //private AudioSource audioSrc;
    //private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if(firstPlayInt == 0)
        {
            backgroundFloat = .125f;
            soundEffectsFloat = 0.75f;
            backgroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundSlider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectsSlider.value = soundEffectsFloat;
        }
        
        
        
        // audioSrc = GetComponent<AudioSource>();
    }
    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsSlider.value);

    }
    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            SaveSoundSettings();
        }
    }


    public void UpdateSound()
    {
        backgroundAudio.volume = backgroundSlider.value;
        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsSlider.value;
        }
    }
 
}
