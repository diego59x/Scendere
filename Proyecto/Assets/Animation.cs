using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public float maxHeight;
    public float minHeight;
    public Pausa pausa;
    private bool pause;
    //Animaciones
    public GameObject esfera;
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


                    if (esfera.transform.position.x > minHeight && touch.position.x < Screen.width / 2 && esfera.transform.position.x == 0f)
                    {
                        esfera.GetComponent<Animator>().Play("Izquierda");
                        //transform.position += new Vector3(minHeight, 0, 0);
                    }
                    else if (esfera.transform.position.x < maxHeight && touch.position.x > Screen.width / 2 && esfera.transform.position.x == 0f)
                    {
                        esfera.GetComponent<Animator>().Play("Derecha");

                        //transform.position += new Vector3(maxHeight, 0, 0);
                    }else if (esfera.transform.position.x == maxHeight && touch.position.x < Screen.width / 2)
                    {
                        
                        esfera.GetComponent<Animator>().Play("Center");
                    }
                    else if (esfera.transform.position.x == minHeight && touch.position.x > Screen.width / 2)
                    {
                        
                        esfera.GetComponent<Animator>().Play("Center");
                    }
                }
            }
        }
    }
}
