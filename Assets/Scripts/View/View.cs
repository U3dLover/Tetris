﻿using DG.Tweening;
using UnityEngine;

/**
*  作   者 ：胡朋
*  github : https://github.com/xiaomoinfo
*  描   述 ：视图
*/
public class View : MonoBehaviour
{

    private RectTransform logoName;

    private RectTransform menUI;
    private RectTransform gameUI;
    private RectTransform gameOverUI;
    private RectTransform settingUI;
    private RectTransform restartButton;
    private RectTransform pauseButton;
    private RectTransform audioButton;


    private void Awake()
    {
        logoName = transform.Find("Canvas/Logo") as RectTransform;

        menUI = transform.Find("Canvas/MenuUI") as RectTransform;
        gameUI = transform.Find("Canvas/GameUI") as RectTransform;
        gameOverUI = transform.Find("Canvas/GameOverUI") as RectTransform;
        settingUI = transform.Find("Canvas/SettingUI") as RectTransform;
        restartButton = transform.Find("Canvas/MenuUI/Restart") as RectTransform;
        pauseButton = transform.Find("Canvas/MenuUI/Pause") as RectTransform;
        audioButton = transform.Find("Canvas/SettingUI/Background/Audio/Volume/Mute") as RectTransform;
    }


    /// <summary>
    /// 显示菜单UI
    /// </summary>
    public void ShowMenuUI()
    {
        logoName.gameObject.SetActive(true);
        logoName.DOAnchorPosY(439.5f, 0.5f);

        menUI.gameObject.SetActive(true);
        menUI.DOAnchorPosY(76.5f, 0.5f);
    }

    /// <summary>
    /// 隐藏菜单ui
    /// </summary>
    public void HideMenuUI()
    {
        logoName.DOAnchorPosY(640f, 0.5f)
            .OnComplete(delegate { logoName.gameObject.SetActive(false); });

        menUI.DOAnchorPosY(-95f, 0.5f)
            .OnComplete(delegate { menUI.gameObject.SetActive(false); });
    }

    /// <summary>
    /// 显示游戏分数UI
    /// </summary>
    public void ShowGameUI()
    {
        gameUI.gameObject.SetActive(true);
        gameUI.DOAnchorPosY(-61f, 0.5f);
    }

    /// <summary>
    /// 隐藏游戏分数UI
    /// </summary>
    public void HideGameUI()
    {
        gameUI.DOAnchorPosY(-70f, 0.5f)
            .OnComplete(delegate { gameUI.gameObject.SetActive(false); });
    }


    public void HideRestartButton()
    {
        restartButton.gameObject.SetActive(false);
    }


    public void ShowRestartButton()
    {
        restartButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    public void showGameOverUI()
    {
        gameOverUI.gameObject.SetActive(true);
    }


    public void HideGameOverUI()
    {
        gameOverUI.gameObject.SetActive(false);
    }
    
    
    public void showSettingUI()
    {
        settingUI.gameObject.SetActive(true);
    }


    public void HideSettingUI()
    {
        settingUI.gameObject.SetActive(false);
    }


    public void ToggleAudioButton()
    {
        GameContext.Mute = !GameContext.Mute;
        audioButton.gameObject.SetActive(GameContext.Mute);
    }
    
    
}
