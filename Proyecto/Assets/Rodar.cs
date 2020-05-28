using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodar : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject fuente;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        transform.RotateAround(fuente.transform.position,Vector3.up,speed *Time.deltaTime);
    }
}
