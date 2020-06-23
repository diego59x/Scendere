using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodar : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject fuente;
    public Material material_1, material_2, material_3, material_4, material_5, material_6, material_7, material_8;
    private Renderer myrend;
    private static readonly string SelectMaterial = "SelectMaterial";
    void Awake()
    {
        myrend = this.GetComponent<Renderer>();
    }
    void Start()
    {
        Time.timeScale = 1;
        int getMaterial;

        getMaterial = PlayerPrefs.GetInt(SelectMaterial);
        switch (getMaterial)
        {
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
            case 5:
                myrend.material = material_5;
                break;
            case 6:
                myrend.material = material_6;
                break;
            case 7:
                myrend.material = material_7;
                break;
            case 8:
                myrend.material = material_8;
                break;
            default:
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        transform.RotateAround(fuente.transform.position,Vector3.up,speed *Time.deltaTime);
    }
}
