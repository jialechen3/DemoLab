using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Killzone : MonoBehaviour
{
       [SerializeField] GameObject controller;
        public void Start()
        {
            
        }

    private void OnCollisionEnter2D (Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                controller.GetComponent<ScoreKeeper>().DeductLife();
            }

            if (collision.gameObject.tag == "Bullet")
            {
                Debug.Log("Missed");
            }

        }

       
    
}
