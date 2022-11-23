using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class ScorePopupController : Controller
{
    public const string SCOREPOPUP_SCENE_NAME = "ScorePopup";

    public override string SceneName()
    {
        return SCOREPOPUP_SCENE_NAME;
    }
}