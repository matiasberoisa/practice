﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{    
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.scoreManager.RaiseScore(1);
        
        Destroy(transform.parent.gameObject);
    }
}