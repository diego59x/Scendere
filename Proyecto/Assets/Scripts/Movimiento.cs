using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private bool isPaused;
    [SerializeField] private GameObject deadMenu;
    public float speed;
    private Animator animation;
    private int kiwis;
    public float plusVelocity = 0;
    public Text scoreText;
    public Text kiwiText;
    public float maxHeight;
    public float minHeight;
    // Start is called before the first frame update 
    void Start()
    {
        animation = GetComponent<Animator>();
        
    }

    // Update is called once per frame
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
        if (transform.position.z == -0.33f)
        {
            animation.enabled = false;
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
