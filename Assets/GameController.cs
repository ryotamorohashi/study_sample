using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject itemData;
    public List<GameObject> item;

    private int score;
    private int maxItem;
    private int nowItem;
    private float x;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        maxItem = 0;
        nowItem = maxItem;
        x = -6;

        item = new List<GameObject> ();

        for(int i=0; i < maxItem; i++) {
            x = -6.0f + (i * 3.0f);
            item.Add(Instantiate(itemData, new Vector3 (x, 1.0f, Random.Range(-9.0f, 9.0f)), Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore() {
        score += 100;
    }

    public void subItem() {
        nowItem--;
    }

    public int getScore() {
        return score;
    }

    public int getNewItem() {
        return nowItem;
    }
}
