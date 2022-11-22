using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class PopupVoteController : Controller
{
    public const string POPUPVOTE_SCENE_NAME = "PopupVote";

    public override string SceneName()
    {
        return POPUPVOTE_SCENE_NAME;
    }
}