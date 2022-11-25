using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    private static SaveManager instance;

    public static SaveManager getInstance()
    {
        if (instance is null)
        {
            instance = new SaveManager();
        }
        return instance;
    }

    private const string SAVE_ENERGY = "LIFE";
    private int liveSave;


    // Start is called before the first frame update
    private void Start()
    {

    }

    protected virtual string GetSaveLife()
    {
        return SaveManager.SAVE_ENERGY;
    }

    public virtual void LoadSaveLife()
    {
        liveSave = PlayerPrefs.GetInt(this.GetSaveLife());
        Debug.Log($"LoadSaveGame: " + liveSave);
    }

    public virtual void SaveLife()
    {
        Debug.Log($"SaveGame");
        liveSave -= liveSave;
        PlayerPrefs.SetInt(this.GetSaveLife(), liveSave);
    }
}
