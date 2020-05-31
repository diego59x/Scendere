using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System.Net.Http.Headers;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private bool isPaused;
    [SerializeField] private GameObject deadMenu;
   
    public float speed;
    public AudioSource bite;
    public AudioSource death;
    private int kiwis;
    public float plusVelocity = 0;
    public Text scoreText;
    public Text kiwiText;
    public float maxHeight;
    public float minHeight;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > minHeight)
        {
            transform.position = transform.position + new Vector3(minHeight, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxHeight)
        {
            transform.position = transform.position + new Vector3(maxHeight, 0, 0);
        }
   
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
                ActivateMenu();
            }
            if (scoreText && kiwiText)
            {
                scoreText.text = "Distance recorred: " + transform.position.z.ToString();
                kiwiText.text = "Kiwis collected: " + kiwis.ToString();
            }
            //Debug.Log("posicion: " + transform.position.z);
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
  
        Time.timeScale = 0;
        deadMenu.SetActive(true);
    }
}
