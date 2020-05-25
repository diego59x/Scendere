using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    public float speed;
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Vector3 tempPos = transform.position;
    }
   
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.08f,0,tempPos.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.08f, 0, tempPos.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        DeadactivateMenu();
       
    }
    void DeadactivateMenu()
    {
        // AudioListener.pause = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
