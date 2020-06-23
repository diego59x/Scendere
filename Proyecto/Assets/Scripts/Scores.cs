using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scores : MonoBehaviour
{
    private static readonly string ContDis = "ContDis";
    private static readonly string ContKiwi = "ContKiwi";
    private static int kiwisb;
    private static int distb;
    public Text kiwiText;
    public Text DisText;
  
    private void Awake()
    {
        distb = PlayerPrefs.GetInt(ContDis);
        DisText.text = "Your total distance is: " + distb.ToString();

        kiwisb = PlayerPrefs.GetInt(ContKiwi);
        kiwiText.text = "You have " + kiwisb.ToString() + " Kiwis";

    }
}
