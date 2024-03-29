﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausa : MonoBehaviour
{
    
    [SerializeField] private bool isPaused;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    // Update is called once per frame
    public void PauseMenu()
    {
        
        isPaused = !isPaused;
        
        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeadactivateMenu();
        }
    }
    public void ActivateMenu()
    {
        AudioListener.pause = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void DeadactivateMenu()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        isPaused = false;
    }
    public void AudioScene()
    {
        SceneManager.LoadScene("Audio");
    }
    public void MainScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public bool GetPause()
    {
        return isPaused;
    }
  
}
