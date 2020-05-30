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
    public Material material_1, material_2, material_3, material_4;
    private Renderer myrend;
    private static readonly string SelectMaterial = "SelectMaterial";


    public float speed;
    public AudioSource bite;
    public AudioSource death;
    //private Animator animatin;
    private int kiwis;
    public float plusVelocity = 0;
    public Text scoreText;
    public Text kiwiText;
    public float maxHeight;
    public float minHeight;
    // Start is called before the first frame update 
    void Awake()
    {
        myrend = this.GetComponent<Renderer>();
    }
    void Start()
    {
        //animatin = GetComponent<Animator>();
        int getMaterial;

        getMaterial = PlayerPrefs.GetInt(SelectMaterial);
        switch(getMaterial){
            case 1:
                myrend.material = material_1;
                break;
            case 2:
                myrend.material = material_2;
                break;
            case 3:
                myrend.material = material_3;
                break;
            case 4:
                myrend.material = material_4;
                break;
            default:
                break;

        }
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
        //if (transform.position.z >= -0.33f)
        //{
        //    animatin.enabled = false;
        //}
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
