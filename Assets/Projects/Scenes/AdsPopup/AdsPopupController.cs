using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class AdsPopupController : Controller
{
    public const string ADSPOPUP_SCENE_NAME = "AdsPopup";

    public override string SceneName()
    {
        return ADSPOPUP_SCENE_NAME;
    }
}