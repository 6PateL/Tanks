using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ChangeResolution : MonoBehaviour
{
  public Dropdown resolutionDropdown;
  Resolution[] resolutions;

  private void Start() 
  {
    resolutionDropdown.ClearOptions();
    List<string> options = new List<string>();
    resolutions = Screen.resolutions;
    int currentResolutionIndex = 0;
    for(int i = 0; i < resolutions.Length;i++)
    {
      string option = resolutions[i].width + "x" + resolutions[i].height + "" + resolutions[i].refreshRate + "Hz"; 
      options.Add(option); 
      if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
      {
         currentResolutionIndex = i; 
      }
    }
    resolutionDropdown.AddOptions(options);
    resolutionDropdown.RefreshShownValue();
    LoadSettings(currentResolutionIndex);
  }

  public void SetResolution(int ResolutionIndex)
  {
    Resolution resolution = resolutions[ResolutionIndex];
    Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen); 
  }

  public void SetFullScreen(bool IsFullScreen)
  {
    Screen.fullScreen = true; 
  }

  public void SaveSettings()
  {
    PlayerPrefs.SetInt("ResolutionPeference",resolutionDropdown.value);
    PlayerPrefs.SetInt("FullScreenPreference",System.Convert.ToInt32(Screen.fullScreen)); 
  }

  public void LoadSettings(int currentResolutionIndex)
  {
    if(PlayerPrefs.HasKey("ResolutionPeference"))
    {
      resolutionDropdown.value = PlayerPrefs.GetInt("ResolutionPeference");
    }
    else
      resolutionDropdown.value = currentResolutionIndex; 
    if(PlayerPrefs.HasKey("FullScreenPreference"))
    {
      Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("FullScreenPreference"));
    }
    else
      Screen.fullScreen = true;
  }
}
