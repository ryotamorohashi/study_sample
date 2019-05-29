using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    
    public GameObject game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {

    }

     void OnTriggerEnter(Collider c) {
        game.GetComponent<GameController>().addScore();
        game.GetComponent<GameController>().subItem();
        Destroy (this.gameObject);
    }
}
