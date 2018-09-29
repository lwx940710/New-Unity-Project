using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    private Vector3 offset = new Vector3(0, 2.89f, -28f);

	// Use this for initialization
	void Start () {
        transform.position = player.position + offset;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
