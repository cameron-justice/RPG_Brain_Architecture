using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour {

    public static SettingsManager _SM;
    
    private Slider volumeSlider;
    private bool fullscreenValue;
    private Button fullscreenButton;
    private Slider brightnessSlider;

    private void Start()
    {
        if(_SM == null)
        {
            _SM = this;
        }
        else
        {
            DestroyImmediate(this);
        }

        DontDestroyOnLoad(this);
    }

    public void SaveSettings()
    {
        AudioListener.volume = volumeSlider.value;
        Screen.fullScreen = fullscreenValue;
        //Brightness when that gets figured out

        PlayerPrefsManager._PPM.SetKey(PlayerPrefsManager._PPM.prefsKey_Volume, volumeSlider.value);
        PlayerPrefsManager._PPM.SetKey(PlayerPrefsManager._PPM.prefsKey_Fullscreen, fullscreenValue);
    }

    public void SetFullscreen(bool newSetting)
    {
        fullscreenValue = newSetting;
    }
}
