using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour
{
    public enum MainMenuMode // your custom enumeration
    {
        MainMenu,
        Synopse,
        Credit,
        Setting,
        Materi,
        Keluar
    };

    public GameObject mainMenuContainer;
    public GameObject synopseContainer;
    public GameObject creditContainer;
    public GameObject settingContainer;
    public GameObject materiContainer;
    public GameObject keluarContainer;


    private MainMenuMode mainMenuMode;

    public void Start()
    {
        AudioPlayer.instance.ChangeSfxVolume(0f);
        AudioPlayer.instance.PlayBGM(0);
    }

    public void Awake()
    {
        ClickMainMenu();
    }

    public void ClickMainMenu()
    {
        AudioPlayer.instance.PlaySFX(0);
        mainMenuMode = MainMenuMode.MainMenu;
        SetState();
    }
    public void ClickSynopse()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        mainMenuMode = MainMenuMode.Synopse;
        SetState();
    }
    public void ClickCredit()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        mainMenuMode = MainMenuMode.Credit;
        SetState();
    }
    public void ClickSetting()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        mainMenuMode = MainMenuMode.Setting;
        SetState();
    }
    public void ClickMateri()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        mainMenuMode = MainMenuMode.Materi;
        SetState();
    }
    public void ClickKeluar()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        mainMenuMode = MainMenuMode.Keluar;
        SetState();
    }
    public void ClickExit()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        Application.Quit();
    }
    
    public void ClickPlay()
    {
        AudioPlayer.instance.ChangeSfxVolume(1f);
        AudioPlayer.instance.PlaySFX(0);
        SceneManager.LoadScene("Gameplay1");
    }

    private void SetState()
    {
        mainMenuContainer.SetActive(false);
        synopseContainer.SetActive(false);
        creditContainer.SetActive(false);
        settingContainer.SetActive(false);
        materiContainer.SetActive(false);
        keluarContainer.SetActive(false);


        switch (mainMenuMode)
        {
            case MainMenuMode.Synopse:
                synopseContainer.SetActive(true);
                break;
            case MainMenuMode.MainMenu:
                mainMenuContainer.SetActive(true);
                break;
            case MainMenuMode.Credit:
                creditContainer.SetActive(true);
                break;
            case MainMenuMode.Setting:
                settingContainer.SetActive(true);
                break;
            case MainMenuMode.Materi:
                materiContainer.SetActive(true);
                break;
            case MainMenuMode.Keluar:
                keluarContainer.SetActive(true);
                break;
        }
    }
}
