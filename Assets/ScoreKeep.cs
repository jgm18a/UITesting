using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeep : MonoBehaviour
{
    public Text score;
    public Text HighScoreTXT;
    public int actualScore;

    private string SCORE = "High Score: ";
    // Start is called before the first frame update
    void Start()
    {
        actualScore = 0;
        HighScoreTXT.text = "High Score: " + PlayerPrefs.GetInt(SCORE);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + actualScore;
    }
    public void AddPoint()
    {
        actualScore++;
        if (PlayerPrefs.GetInt(SCORE)<= actualScore)
        {
            PlayerPrefs.SetInt(SCORE,actualScore);
        }
        HighScoreTXT.text =  "High Score: " + PlayerPrefs.GetInt(SCORE);
    }
}
