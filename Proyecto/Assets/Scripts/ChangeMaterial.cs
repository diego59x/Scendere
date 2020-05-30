using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    private static readonly string SelectMaterial = "SelectMaterial";
    public GameObject sphere;
    public Material material_1, material_2, material_3, material_4;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = sphere.GetComponent<Renderer>();

    }
    public void material1()
    {
        PlayerPrefs.SetInt(SelectMaterial, 1);
        rend.material = material_1;
    }
    public void material2()
    {
        PlayerPrefs.SetInt(SelectMaterial, 2);
        rend.material = material_2;
    }
    public void material3()
    {
        PlayerPrefs.SetInt(SelectMaterial, 3);
        rend.material = material_3;
    }
    public void material4()
    {
        PlayerPrefs.SetInt(SelectMaterial, 4);
        rend.material = material_4;
    }
}
