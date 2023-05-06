using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] string playerName;
    //[SerializeField] int bulletNum;
    public static PersistentData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }

        else
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerName = "";
        playerScore = 10;
        //bulletNum = 10;
        
    }
    public void SetName(string name)
    {
        playerName = name;
    }

    public void SetScore(int score)
    {
        playerScore = score;
    }

    public string GetName()
    {
        return playerName;
    }

    public int GetScore()
    {
        return playerScore;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
