using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class SliderValueToText : MonoBehaviour
{
    public Text percentageText;

    void Start()
    {
        percentageText = GetComponent<Text>();
    }

    public void textUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
    }

}