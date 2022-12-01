using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;
using System;

public class AdsPopupController : Controller
{
    public const string ADSPOPUP_SCENE_NAME = "AdsPopup";

    public override string SceneName()
    {
        return ADSPOPUP_SCENE_NAME;
    }

    public void OnYButtonTap()
    {
        int lifeCount = Int32.Parse(GameMgr.getInstance().lifeSave) + 5;
        GameMgr.getInstance().SaveLife(lifeCount.ToString());
        StartCoroutine(LoadingToHome());
    }

    IEnumerator LoadingToHome()
    {
        Manager.LoadingAnimation(true);

        yield return new WaitForSeconds(0.5f);

        Manager.LoadingAnimation(false);

        Manager.Load(HomeController.HOME_SCENE_NAME);
    }
}