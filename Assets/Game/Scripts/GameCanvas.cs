using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class GameCanvas : MonoBehaviour
{
    private void Start()
    {
        SetSoundsSettings();
        LoadCompletedLevels();
    }

    private void SetSoundsSettings()
    {
        bool sounds = YandexGame.savesData.soundsSettings_sdk;

        if (sounds)
        {
          //  soundsButtonImage.sprite = soundsOnSprite;
          //  buttonPlayer.volume = 1f;
        }
        else
        {
         //   soundsButtonImage.sprite = soundsOffSprite;
          //  buttonPlayer.volume = 0f;
        }
    }
    private void LoadCompletedLevels()
    {

    }
}