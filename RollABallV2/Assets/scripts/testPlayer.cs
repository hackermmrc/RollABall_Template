using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPlayer : MonoBehaviour {

    public Vector3 offset;
    public float moveSpeed = 1000f;
    Rigidbody rb;
    public Vector3 checkpoint;
    public Vector3 checkpointOffset;
    public GameManger gm;


	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float hdir = Input.GetAxisRaw("Horizontal");
        float vdir = Input.GetAxisRaw("Vertical");

        Vector3 directionVector = new Vector3(hdir, 0, vdir);
        Vector3 unitVector = directionVector.normalized;
        Vector3 forceVector = unitVector * moveSpeed * Time.deltaTime;

        rb.AddForce(forceVector);

       

    }

   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "deathwall")
        {
            gm.playerDeath();
            transform.position = checkpoint;
            rb.Sleep();

        }

        if (other.gameObject.tag == "checkpoint")
        {
            if (checkpoint != other.transform.position)
            {
                //checkpoint = other.transform.position;
                checkpoint = checkpointOffset;

            }
        }

    }

}
