using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ManejoEscenas : MonoBehaviour
{
  
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void AudioScene()
    {
        SceneManager.LoadScene("Audio");
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void CostumeScene()
    {
        SceneManager.LoadScene("Costume");
    }

}
