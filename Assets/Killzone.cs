using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Killzone : MonoBehaviour
{
       
        public void Start()
        {
            
        }

    private void OnCollisionEnter2D (Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                    SceneManager.LoadScene("Level1");
            }

            if (collision.gameObject.tag == "Bullet")
            {
                Debug.Log("Missed");
            }

        }

       
    
}
