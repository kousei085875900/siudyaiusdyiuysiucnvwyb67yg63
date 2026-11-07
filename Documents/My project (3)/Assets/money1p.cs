using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class money1p : MonoBehaviour
{
    public TextMeshProUGUI money;
    public Image Image1;
    public Image Image2;
    public Image Image2_1;
    public Image Image2_2;
    public Image Image3_1;
    public Image Image3_2;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        money.text = PlaceBlock.mony.ToString();
        if (int.Parse(money.text) < 10)
        {
            Image1.enabled = false;
            Image2.enabled = true;
        }
        else
        {
            Image1.enabled = true;
            Image2.enabled = false;
        }

        money.text = PlaceBlock.mony.ToString();
        if (int.Parse(money.text) < 20)
        {
            Image2_1.enabled = false;
            Image2_2.enabled = true;
        }
        else
        {
            Image2_1.enabled = true;
            Image2_2.enabled = false;
        }

        money.text = PlaceBlock.mony.ToString();
        if (int.Parse(money.text) < 30)
        {
            Image3_1.enabled = false;
            Image3_2.enabled = true;
        }
        else
        {
            Image3_1.enabled = true;
            Image3_2.enabled = false;
        }
    }
}
