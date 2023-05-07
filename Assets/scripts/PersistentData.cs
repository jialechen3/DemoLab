using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] string playerName;

    [SerializeField] int life;
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
            playerScore = 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        life = 2;
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

    public void SetLife(int lifes) {
        life = lifes;
    }
    public string GetName()
    {
        return playerName;
    }

    public int GetScore()
    {
        return playerScore;
    }

    public int GetLife()
    {
        return life;
    }

    public int SetLife()
    {
        return life;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
