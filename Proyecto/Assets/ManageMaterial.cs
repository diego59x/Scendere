using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMaterial : MonoBehaviour
{
    public Material material_1, material_2, material_3, material_4;
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
            default:
                break;

        }
    }
}
