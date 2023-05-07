using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //[SerializeField] AudioSource audio;
    [SerializeField] GameObject controller;
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    [SerializeField] public float Speed;
    private Rigidbody2D rb;
    private Transform currentPoint;

    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
           controller = GameObject.FindGameObjectWithTag("GameController");
        }
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointA.transform;
        //if (audio == null)
       //     audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointA.transform) {
            rb.velocity = new Vector2(0, Speed);
        }
        else
            rb.velocity = new Vector2(0, -Speed);
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
            currentPoint = pointA.transform;
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
            currentPoint = pointB.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        
    }
}
