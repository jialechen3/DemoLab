using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    int score, life;
    [SerializeField] TMP_Text scoreTxt;
    [SerializeField] TMP_Text lifeTxt;
    
    int level;
    //int bulletNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        life = PersistentData.Instance.GetLife();
        Debug.Log("Bullet left: "+ score);
        DisplayScore();
        DisplayLife();
        
        //level = SceneManager.GetActiveScene().buildIndex - 1; //becuase build indexing starts at 0 and we start right awy with scene1
        //scoreThreshold = level * SCORE_THRESHOLD_PER_LEVEL;
        //DisplayScene();
    }

    // Update is called once per frame
    void Update()
    {
        score = PersistentData.Instance.GetScore();
        life = PersistentData.Instance.GetLife();
        if (score == 0) {
            SceneManager.LoadScene("LoseScene");
        }
        if (life == 0) {
            SceneManager.LoadScene("LoseScene");
            PersistentData.Instance.SetLife(2);
        }
    }

    public void DeductLife()
    {
        DeductLife(1);
    }

    public void DeductLife(int points)
    {
        life -= points;
        PersistentData.Instance.SetLife(life);
        Debug.Log("Life: " + life);
        DisplayLife();

    }

    public void DisplayLife()
    {
       lifeTxt.text = ": " + life;
    }

    public void DeductPoints()
    {
        DeductPoints(1);
    }

    public void AddPoints() {
        score += 3;
        PersistentData.Instance.SetScore(score);
        Debug.Log("Bullet: " + score);
        DisplayScore();
    }

    public void DeductPoints(int points)
    {
        score -= 1;
        PersistentData.Instance.SetScore(score);
        Debug.Log("Bullet: " + score);
        DisplayScore();
    }

    public void DisplayScore()
    {
        scoreTxt.text = ": " + score;
        //bulletTxt.text = ": " + bulletNum;
    }

    

    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
