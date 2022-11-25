using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{

    private static GameMgr instance;

    public static GameMgr getInstance()
    {
        if (instance is null)
        {
            instance = new GameMgr();
        }
        return instance;
    }

    private const string SAVE_LIFE = "LIFE";
    public string lifeSave;

    protected virtual string GetSaveLife()
    {
        return GameMgr.SAVE_LIFE;
    }

    public virtual void LoadSaveLife()
    {
        if(PlayerPrefs.GetString(this.GetSaveLife()) == "")
        {
            PlayerPrefs.SetString(this.GetSaveLife(), "3");
            lifeSave = PlayerPrefs.GetString(this.GetSaveLife());
        }
        else
        {
            lifeSave = PlayerPrefs.GetString(this.GetSaveLife());
        }
    }

    public virtual void SaveLife(string life)
    {
        Debug.Log($"SaveGame");
        PlayerPrefs.SetString(this.GetSaveLife(), life);
    }
}
