using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;
public class OptionsScreen : MonoBehaviour
{
    public AudioMixer TheMixer;
    public TMP_Text mastLabel, musicLabel, sfxLabel;
    public Slider mastSlider, musicSlider, sfxSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    float vol = 0f;
    TheMixer.GetFloat("MasterVol",out vol);
    mastSlider.value = vol;

    TheMixer.GetFloat("MusicVol",out vol);
    musicSlider.value = vol;

    TheMixer.GetFloat("SFXVol",out vol);
    sfxSlider.value = vol;

    mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();

    musicLabel.text = Mathf.RoundToInt(musicSlider.value + 80).ToString();

    sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetMasterVol()
    {
    mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();

    TheMixer.SetFloat("MasterVol", mastSlider.value);
    

    PlayerPrefs.SetFloat("MasterVol", mastSlider.value);
    }
   
   
    public void SetMusicVol()
    {
    musicLabel.text = Mathf.RoundToInt(musicSlider.value + 80).ToString();

    TheMixer.SetFloat("MusicVol", musicSlider.value);
    
    PlayerPrefs.SetFloat("MusicVol", musicSlider.value);
    }


    public void SetSFXVol()
    {
    sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();

    TheMixer.SetFloat("SFXVol", sfxSlider.value);
    
    PlayerPrefs.SetFloat("SFXVol", sfxSlider.value);
    }
}
