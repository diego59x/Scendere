using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    private Vector3 distVec;
    public float speed;
    void Start()
    {
        if (player)
            distVec = player.transform.position - transform.position;
    }
    private void Update()
    {
        if (player)
            transform.position = player.transform.position - distVec;

        //transform.Translate(0, 0, speed * Time.deltaTime);
    }

    // Update is called once per frame

}
