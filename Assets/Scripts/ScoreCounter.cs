﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoreText.text = player.position.z.ToString("0");
        if(player.position.z >= 300)
        {
            scoreText.canvas.enabled = false;
        }
    } 
}
