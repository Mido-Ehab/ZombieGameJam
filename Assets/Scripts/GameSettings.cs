using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
        }
        
    }

    public void SetMusicVolume()
    {
        float voulme = musicSlider.value;

        audioMixer.SetFloat("Music",Mathf.Log10(voulme)*20);

        PlayerPrefs.SetFloat("Music",voulme);
    }

    //to save the previous volume settings
    void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("Music");
        SetMusicVolume();
    }

}
