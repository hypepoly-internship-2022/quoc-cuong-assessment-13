using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using SS.View;
public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && !isMouseOverUI())
        {
            Manager.Load(ScorePopupController.SCOREPOPUP_SCENE_NAME, "ScorePopup");
        }
    }

    private bool isMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();    
    }
}
