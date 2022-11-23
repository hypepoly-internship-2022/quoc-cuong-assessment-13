using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectLevelPopup : MonoBehaviour
{

    [SerializeField] private GameObject levelBtnPrefab;
    [SerializeField] private Transform inventory;
    [SerializeField] private int levelBlockUWant;

    // Start is called before the first frame update
    private void Start()
    {
        spawnLevelBtn();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

     private void spawnLevelBtn()
     {
        for(int i = 0; i < 30; i++)
        {
            GameObject btn = Instantiate(levelBtnPrefab, new Vector3(0,0,0), Quaternion.identity);
            btn.transform.SetParent(inventory);
            btn.transform.localScale = new Vector3(1,1,0);
            btn.name = (i+1).ToString();

            btnPrefab(btn, i, levelBlockUWant);
        }   
    }

    private void btnPrefab(GameObject obj, int level, int levelBlock)
    {
        for(int i = 0; i < obj.transform.GetChild(0).childCount; i++)
        {
            Transform childParent = obj.transform.GetChild(0);
            Transform curChild = childParent.transform.GetChild(i);
            if(curChild.name.Equals("BannerGameBtn"))
            {
                curChild.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + (level + 1);
            }

            if(level >= levelBlock)
            {
                if(curChild.name.Equals("Star"))
                {
                    curChild.gameObject.SetActive(false);
                    Button btnLv = obj.transform.GetChild(0).GetComponent<Button>();
                    btnLv.interactable = false;
                }
            }
        }
    }
}
