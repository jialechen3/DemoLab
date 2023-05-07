using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] AudioSource musicSource;
    public AudioClip sfx;
    
    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        musicSource.clip = sfx;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Hit:" + collision.gameObject.tag);
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Stone") {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Target") {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            musicSource.Play();
        }
        

    }
}
