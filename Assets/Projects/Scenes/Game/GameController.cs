using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class GameController : Controller
{
    public const string GAME_SCENE_NAME = "Game";

    public override string SceneName()
    {
        return GAME_SCENE_NAME;
    }

    public void OnPauseButtonTap()
    {
        GameMgr.getInstance().isPaused = true;
        Manager.Add(PausePopupController.PAUSEPOPUP_SCENE_NAME, "PausePopup");
    }

}