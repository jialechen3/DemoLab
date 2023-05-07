using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class ButtonFuntion : MonoBehaviour
{
    [SerializeField] TMP_InputField playerNameInput;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject levelMenu;
    public bool isPaused = false;
    public GameObject settingMenu;
    [SerializeField] AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        //playerNameInput.text = PersistentData.Instance.GetName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        
        
        

        // PersistentData.Instance.SetScore(10);
        // SceneManager.LoadScene("Level1");
    }


    public void SettingOn()
    {
        settingMenu.SetActive(true);
        isPaused = true;
    }
    public void SettingOff()
    {
        settingMenu.SetActive(false);
        isPaused = false;
    }
    public void PauseOn()
    {
        
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void PauseOff()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void levelOn()
    {
        string playerName = playerNameInput.text;
        PersistentData.Instance.SetName(playerName);
        levelMenu.SetActive(true);
        isPaused = true;
    }
    public void levelOff()
    {
        levelMenu.SetActive(false);
        isPaused = false;
    }

    public void level1() {
        PersistentData.Instance.SetScore(10);
        PersistentData.Instance.SetLife(2);
        SceneManager.LoadScene("Level1");
    }

    public void level2() {
        PersistentData.Instance.SetScore(10);
        PersistentData.Instance.SetLife(1);
        SceneManager.LoadScene("Level1");
    }

    public void level3() {
        PersistentData.Instance.SetScore(5);
        PersistentData.Instance.SetLife(1);
        SceneManager.LoadScene("Level1");
    }

    public void insane() {

    }
    public void MainMenu() {
        PersistentData.Instance.SetLife(2);
        SceneManager.LoadScene("Menu");
        
    }

    public void quit() {
        Application.Quit();
    }

}
