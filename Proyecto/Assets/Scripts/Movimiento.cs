using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System.Net.Http.Headers;
using UnityEditor;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private bool isPaused;
    public GameObject deadMenu;
    public GameObject actualMenu;
    private static readonly string ContKiwi = "ContKiwi";
    private static readonly string ContDis = "ContDis";
    private int kiwis = 0;
    public float speed;
    private int distance = 0;
    public AudioSource bite;
    public AudioSource death;
    public float plusVelocity = 0;
    public Text scoreText;
    public Text kiwiText;
    public Text actual;
    public float maxHeight;
    public float minHeight;
    // Para usar con: https://docs.unity3d.com/ScriptReference/TouchPhase.Moved.html
    //public Vector2 startPos;
    //public Vector2 direction;
    //Para pausa
    //https://docs.unity3d.com/2017.3/Documentation/ScriptReference/Rect-ctor.html https://forum.unity.com/threads/defining-areas-of-the-screen-for-touch-input.127103/
    public Pausa pausa;
    private bool pause;
    void Start()
    {
        Time.timeScale = 1;
        pause = pausa.GetPause();
    }
    void Update()
    {
  
        if (pause == false)
        {
            foreach (Touch touch in Input.touches)
            {
               if (touch.phase == TouchPhase.Began)
               {
                    

                    if (transform.position.x > minHeight && touch.position.x < Screen.width / 2)
                    {
                        
                        transform.position += new Vector3(minHeight, 0, 0);
                    }
                    else if (transform.position.x < maxHeight && touch.position.x > Screen.width / 2)
                    {

                        transform.position += new Vector3(maxHeight, 0, 0);
                    }
               }
            }
        }
        
      

        // Codigo para teclas A D computadora
        //if (Input.GetKeyDown(KeyCode.A) && transform.position.x > minHeight)
        //{
        //    transform.position = transform.position + new Vector3(minHeight, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxHeight)
        //{
        //    transform.position = transform.position + new Vector3(maxHeight, 0, 0);
        //}

        distance = (int)transform.position.z;
        actual.text = "Distance recorred: " + distance.ToString() + "m\nKiwis collected: " + kiwis.ToString();

       
       

    }

    private void FixedUpdate()
    {
        if (plusVelocity > 3f)
        {
            plusVelocity = 1.8f;
        }
        transform.Translate(Vector3.forward * (speed  + plusVelocity) * Time.deltaTime);
       // Vector3 tempPos = transform.position;

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Shock"))
        {
            death.Play();
            isPaused = !isPaused;

            if (isPaused)
            {
                distance = (int)transform.position.z;
                PlayerPrefs.SetInt(ContKiwi, kiwis + PlayerPrefs.GetInt(ContKiwi));
                PlayerPrefs.SetInt(ContDis, distance + PlayerPrefs.GetInt(ContDis));
         
                ActivateMenu();
            }
            if (scoreText && kiwiText)
            {
                distance = (int)transform.position.z;
                scoreText.text = "Distance recorred: " + distance.ToString();
                kiwiText.text = "Kiwis collected: " + kiwis.ToString();
            }
            
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kiwi"))
        {
            bite.Play();
            kiwis += 1;
            Destroy(other.gameObject);
            plusVelocity += 1f;

        }
    }

    void ActivateMenu()
    {
        actualMenu.SetActive(false);
        Time.timeScale = 0;
        deadMenu.SetActive(true);
    }

}
