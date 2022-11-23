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

    public void OnQuitButtonTap()
    {
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