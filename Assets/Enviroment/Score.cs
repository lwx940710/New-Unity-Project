﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;

	// Use this for initialization
	void Start () {
        score.text = 0.ToString("0");
	}
	
	// Update is called once per frame
	void Update () {
        score.text = player.position.z.ToString("0");
    }
}
