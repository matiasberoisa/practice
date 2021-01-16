using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
     
    public static ScoreManager scoreManager;
    
    public Text scoreText;
    int score = 0;

    void Start()
    {
        if(scoreManager == null)
        {
            scoreManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    void Update()
    {
        scoreText = GameObject.Find("text").GetComponent<Text>();
        scoreText.text = score + "";
    }
    
    public void RaiseScore(int s)
        {
            score += s;
            scoreText.text = score + "";

            if(score == 3)
            {
            SceneManager.LoadScene("Scene2");
            }
        }
    }
}

