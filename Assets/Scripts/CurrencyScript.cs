using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyScript : MonoBehaviour
{
    static int intValue = 10000;
    public Text currencyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void textUpdate(int value)
    {
        intValue = value;
        currencyText.text = intValue.ToString() + "";
    }

}
