using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ManejoEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void AudioScene()
    {
        SceneManager.LoadScene("Audio");
    }
    public void LevelsScene()
    {
        SceneManager.LoadScene("Levels");
    }
    public void StoreScene()
    {
        SceneManager.LoadScene("Store");
    }
}
