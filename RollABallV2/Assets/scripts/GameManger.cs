using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

    public TestUI tu;

    public GameObject player;

    public Vector3 startSpawn;

    // Use this for initialization
	void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {

        if (tu.tries == 0)
        {
            gameOver();
        }

	}

    public void playerDeath()
    {
        tu.LoseTry();

        //startPosition();
    }
    public void gameOver()
    {
        tu.score = 0;
        tu.tries = 3;
        startPosition();
    }

    public void startPosition()
    {
        player.transform.position = startSpawn; 
    }

}

