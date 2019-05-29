using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CavasController : MonoBehaviour
{
    public Text score;
    public Text nowItem;

    private int scoreData;
    private int nowItemData;

    public GameObject game;
    private GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        gc = game.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreData = gc.getScore();
        nowItemData = gc.getNewItem();

        textChange();
    }

    void textChange() {

        score.text = "Score: " + scoreData.ToString();
        nowItem.text = "nowItem: " + nowItemData.ToString();
    }
}
