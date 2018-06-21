using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour {

    public Text scoreTxt;
    public Text triesTxt;
    public int score;
    public int tries;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        scoreTxt.text = "Score: " + score.ToString();
        triesTxt.text = "Tries: " + tries.ToString();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreTxt.text = "Score: " + score.ToString();
    }
     
    public void LoseTry()
    {
        tries--;
        triesTxt.text = "Tries: " + tries.ToString();
    }

}


