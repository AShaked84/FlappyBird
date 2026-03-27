using UnityEngine;
using UnityEngine.Audio;

public class MasterController : MonoBehaviour
{
    [SerializeField] private AudioMixer myAudioMixer;

    public void SetMasterVolume(float value)
    {
        myAudioMixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }

    public void SetMusicVolume(float value)
    {
        myAudioMixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    }

    public void SetSFXVolume(float value)
    {
        myAudioMixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);
    }
}