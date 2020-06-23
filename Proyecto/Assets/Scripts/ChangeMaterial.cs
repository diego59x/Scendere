using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    private static readonly string SelectMaterial = "SelectMaterial";
    private static readonly string ContKiwi = "ContKiwi";
    public GameObject sphere;
    private static int kiwisb;
    public Text kiwiText;
    public Text aguas;
    public Material material_1, material_2, material_3, material_4, material_5, material_6, material_7, material_8;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
       rend = sphere.GetComponent<Renderer>();
    }
    private void Awake()
    {
        aguas.text = "";
        kiwisb = PlayerPrefs.GetInt(ContKiwi);
        kiwiText.text = "You have " + kiwisb.ToString() + " Kiwis";
    }
    public void material1()
    {
        aguas.text = "";
        PlayerPrefs.SetInt(SelectMaterial, 1);
        rend.material = material_1;
    }
    public void material2()
    {
        aguas.text = "";
        PlayerPrefs.SetInt(SelectMaterial, 2);
        rend.material = material_2;
    }
    public void material3()
    {
        aguas.text = "";
        PlayerPrefs.SetInt(SelectMaterial, 3);
        rend.material = material_3;
    }
    public void material4()
    {
        aguas.text = "";
        PlayerPrefs.SetInt(SelectMaterial, 4);
        rend.material = material_4;
    }
    public void material5()
    {
        if (kiwisb < 30)
        {
            aguas.text = "You don´t have enough kiwis\nYou need 30";
        }
        else
        {
            aguas.text = "";
            PlayerPrefs.SetInt(SelectMaterial, 5);
            rend.material = material_5;
        }
        
    }
    public void material6()
    {
        if (kiwisb < 90)
        {
            aguas.text = "You don´t have enough kiwis\nYou need 90";
        }
        else
        {
            aguas.text = "";
            PlayerPrefs.SetInt(SelectMaterial, 6);
            rend.material = material_6;
        }

    }
    public void material7()
    {
        if (kiwisb < 190)
        {
            aguas.text = "You don´t have enough kiwis\nYou need 190";
        }
        else
        {
            aguas.text = "";
            PlayerPrefs.SetInt(SelectMaterial, 7);
            rend.material = material_7;
        }

    }
    public void material8()
    {
        if (kiwisb < 290)
        {
            aguas.text = "You don´t have enough kiwis\nYou need 290";
        }
        else
        {
            aguas.text = "";
            PlayerPrefs.SetInt(SelectMaterial, 8);
            rend.material = material_8;
        }

    }
}
