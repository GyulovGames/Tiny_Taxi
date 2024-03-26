using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using YG;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] private RectTransform mainMenu;
    [SerializeField] private RectTransform levelsMenu;
    [SerializeField] private RectTransform loadingMenu;
    [SerializeField] private RectTransform allGamesMenu;
    [Space(5)]
    [SerializeField] private Image soundsButtonImage;
    [SerializeField] private Sprite soundsOnSprite;
    [SerializeField] private Sprite soundsOffSprite;
    [Space(5)]
    [SerializeField] private MoveController moveController;
    [SerializeField] private AudioSource buttonPlayer;

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
            soundsButtonImage.sprite = soundsOnSprite;
            buttonPlayer.volume = 1f;
        }
        else
        {
            soundsButtonImage.sprite = soundsOffSprite;
            buttonPlayer.volume = 0f;
        }
    }
    private void LoadCompletedLevels()
    {

    }

    public void btn_OpenLevels()
    {
        buttonPlayer.Play();
        moveController.MoveIn(levelsMenu);
    }
    public void btn_CloseLevels()
    {
        buttonPlayer.Play();
        moveController.MoveOut(levelsMenu);
    }

    public void btn_OpenAllGames()
    {
        buttonPlayer.Play();
        moveController.MoveIn(allGamesMenu);
    }
    public void btn_CloseAllGames()
    {
        buttonPlayer.Play();
        moveController.MoveOut(allGamesMenu);
    }

    public void btn_ChangeSounds()
    {
        bool sounds = YandexGame.savesData.soundsSettings_sdk;

        if (sounds)
        {
            buttonPlayer.volume = 0f;
            soundsButtonImage.sprite = soundsOffSprite;
            YandexGame.savesData.soundsSettings_sdk = false;
        }
        else
        {
            buttonPlayer.volume = 1f;
            soundsButtonImage.sprite = soundsOnSprite;
            YandexGame.savesData.soundsSettings_sdk = true;
        }

        buttonPlayer.Play();
        YandexGame.SaveProgress();
    }
}