using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float velAngular = 0;

    void Update()
    {
        transform.Rotate(new Vector3(velAngular, 0, 0) * Time.deltaTime);
   }
}
