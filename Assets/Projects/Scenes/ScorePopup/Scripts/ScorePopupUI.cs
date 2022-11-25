using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePopupUI : MonoBehaviour
{

    [SerializeField] private GameObject[] star = new GameObject[3];

    private Image star1;
    private Image star2;
    private Image star3;
    // Start is called before the first frame update
    void Start()
    {
        star1 = star[0].GetComponent<Image>();
        star2 = star[1].GetComponent<Image>();
        star3 = star[2].GetComponent<Image>();

        showStar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void showStar()
    {
        // Debug.Log(PlayerController.getInstance().isWon);
        // if(PlayerController.getInstance().isWon == true)
        // {
            star1.color = Color.white;
            star2.color = Color.white;
            star3.color = Color.white;
        // }
    }
}
