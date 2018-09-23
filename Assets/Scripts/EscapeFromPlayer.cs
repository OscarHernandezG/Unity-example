using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeFromPlayer : MonoBehaviour {

    public GameObject player;
    public int speed;

    private Rigidbody body;


    // Use this for initialization
    void Start ()
    {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 move = transform.position - player.transform.position;

        move.y = 0;

        body.AddForce(move * speed);
    }
}
