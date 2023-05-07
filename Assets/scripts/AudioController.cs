using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
 
public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] Slider slider;
    private static AudioController instance;
    public AudioMixer _Audio;

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
        }
        else {
        instance = this;
        DontDestroyOnLoad(gameObject);
        }
    }
    public void SetVolume() {
        float volume = slider.value;
        _Audio.SetFloat("Music", volume);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
