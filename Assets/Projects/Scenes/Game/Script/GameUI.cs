using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SS.View;

public class GameUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private float time;
    [SerializeField] private TextMeshProUGUI heartText;

    private bool endGame;
    private PlayerController playerController;
    private EnemyMovement enemyMovement;
    private int minutes;
    private int seconds;
    private bool checkUpdate;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        enemyMovement = FindObjectOfType<EnemyMovement>();
        GameMgr.getInstance().LoadSaveLife(); 
        heartText.GetComponent<TextMeshProUGUI>().text = GameMgr.getInstance().lifeSave;
        checkUpdate = true;
    }

    // Update is called once per frame
    void Update()
    {
        showTextTime();
        checkWin();
        showPopup();
    }

    private void showTextTime()
    {
        time -= Time.deltaTime;

        minutes = (int) time / 60;
        seconds = (int) time % 60;

        if(minutes < 10)
        {
            if(seconds < 10){
                timeText.GetComponent<TextMeshProUGUI>().text = "0" + minutes + ":0" + seconds;
            }
            else
            {
                timeText.GetComponent<TextMeshProUGUI>().text = "0" + minutes + ":" + seconds;
            }
        }
        else
        {
            timeText.GetComponent<TextMeshProUGUI>().text = minutes + ":" + seconds;
        }
    }

    private void checkWin()
    {
        if(playerController.isWon == true || playerController.isLose == true)
        {
            actionWin();
        }

        if(minutes <= 0 && seconds <= 0)
        {
            actionWin();
        }
    }

    private void actionWin()
    {
        playerController.EndMove();
        enemyMovement.EndMove();
        if(checkUpdate == true)
        {
            endGame = true;
            checkUpdate = false;
        }
    }

    private void showPopup()
    {
        if(endGame ==  true)
        {
            Manager.Load(ScorePopupController.SCOREPOPUP_SCENE_NAME, "ScorePopup");
            endGame = false;
        }
    }
}
