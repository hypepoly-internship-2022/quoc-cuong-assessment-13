using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class SelectLevelController : Controller
{
    public const string SELECTLEVEL_SCENE_NAME = "SelectLevel";

    public override string SceneName()
    {
        return SELECTLEVEL_SCENE_NAME;
    }
}