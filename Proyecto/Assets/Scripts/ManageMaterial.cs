using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMaterial : MonoBehaviour
{
    public Material material_1, material_2, material_3, material_4, material_5, material_6, material_7, material_8;
    private Renderer myrend;
    private static readonly string SelectMaterial = "SelectMaterial";
    public GameObject sphere;
    void Awake()
    {
        myrend = sphere.GetComponent<Renderer>();
    }
    void Start()
    {
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
}
