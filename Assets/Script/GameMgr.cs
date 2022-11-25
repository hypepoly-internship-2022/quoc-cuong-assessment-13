using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    public static SaveManager instance {get; private set;}

    private const string SAVE_ENERGY = "LIFE";
    private int liveSave;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(SaveManager.instance != null)
        {
            Debug.Log($"Only 1 SaveManager allow");
            SaveManager.instance = this;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        this.LoadSaveLife();
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
