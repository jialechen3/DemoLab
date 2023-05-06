using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] public Transform shootingPoint;
    [SerializeField] public GameObject bullet;
    [SerializeField] AudioSource audio;
    [SerializeField] GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            controller.GetComponent<ScoreKeeper>().DeductPoints();
            //AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            Instantiate(bullet, shootingPoint.position, transform.rotation);
        }
    }
}
