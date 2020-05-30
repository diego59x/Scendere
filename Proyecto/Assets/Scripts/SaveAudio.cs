using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAudio : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;

    private void Awake()
    {
        ContinueSetting();
    }

    private void ContinueSetting()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
        backgroundAudio.volume = backgroundFloat;
        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    }

}
