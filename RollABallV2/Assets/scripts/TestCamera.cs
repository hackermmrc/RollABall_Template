using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera : MonoBehaviour {

    public GameObject player;
    public Vector3 offset;
    testPlayer tp;


	// Use this for initialization
	void Start () {
        offset = (Camera.main.transform.position - player.transform.position);
        player = GameObject.Find("player");

	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = player.transform.position + offset;
	}
}
