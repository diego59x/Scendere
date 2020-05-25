using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public float speed;
    void Start()
    {
        
    }
    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    // Update is called once per frame

}
