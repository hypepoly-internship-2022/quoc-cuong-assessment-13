using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class HomeController : Controller
{
    public const string HOME_SCENE_NAME = "Home";

    public override string SceneName()
    {
        return HOME_SCENE_NAME;
    }

    public void OnVoteButtonTap()
    {
        Manager.Add(VotePopupController.VOTEPOPUP_SCENE_NAME, "VotePopup");
    }

    public void OnSettingsButtonTap()
    {
        Manager.Add(SettingsPopupController.SETTINGSPOPUP_SCENE_NAME, "SettingsPopup");
    }
}