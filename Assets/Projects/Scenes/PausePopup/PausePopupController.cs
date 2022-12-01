using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class PausePopupController : Controller
{
    public const string PAUSEPOPUP_SCENE_NAME = "PausePopup";

    public override string SceneName()
    {
        return PAUSEPOPUP_SCENE_NAME;
    }

    public void OnResumeButtonTap()
    {
        GameMgr.getInstance().isPaused = false;
        Manager.Close();
    }

    public void OnQuitButtonTap()
    {
        GameMgr.getInstance().isPaused = false;
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