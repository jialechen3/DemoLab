using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grow : MonoBehaviour
{
    [SerializeField] GameObject controller;
    public float speed = 0.5f;
    public float boxSpeed = 0.01f;
    // public BoxCollider2D coll;
    Vector3 temp, tempBox;
    // Start is called before the first frame update
    void Start()
    {
        // coll = coll.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;
        temp.x += speed * Time.deltaTime;
        temp.y += speed * Time.deltaTime;
        temp.z += speed * Time.deltaTime;
        // tempBox.x += speed * Time.deltaTime;
        // tempBox.y += speed * Time.deltaTime;
        // coll.size = temp;
        transform.localScale = temp;
    }

     private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            controller.GetComponent<ScoreKeeper>().DeductLife();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Killed");
        }

    }
}
