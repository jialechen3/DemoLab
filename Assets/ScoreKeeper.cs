using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    int score = 10;
    const int DEFAULT_POINTS = 1;
    [SerializeField] TMP_Text scoreTxt;
    //[SerializeField] TMP_Text bulletTxt;
    //[SerializeField] Text sceneTxt;
    int level;
    //int bulletNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        DisplayScore();
        
        
        //level = SceneManager.GetActiveScene().buildIndex - 1; //becuase build indexing starts at 0 and we start right awy with scene1
        //scoreThreshold = level * SCORE_THRESHOLD_PER_LEVEL;
        //DisplayScene();
    }

    // Update is called once per frame
    void Update()
    {
        score = PersistentData.Instance.GetScore();
        if (score == 0) {
            SceneManager.LoadScene("LoseScene");
        }
        
    }

    public void DeductPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void AddPoints(int points)
    {
        score -= points;
        PersistentData.Instance.SetScore(score);
        Debug.Log("Bullet: " + score);
        DisplayScore();

       // if (score >= scoreThreshold)
       //     AdvanceScene();
    }

    public void DisplayScore()
    {
        scoreTxt.text = ": " + score;
        //bulletTxt.text = ": " + bulletNum;
    }

    public void DisplayScene()
    {
       // sceneTxt.text = "Welcome, " + PersistentData.Instance.GetName() + " : Level " + level;
    }

    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
