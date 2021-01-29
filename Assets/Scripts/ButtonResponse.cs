using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonResponse : MonoBehaviour
{

    public Button[] ButtonList;
    public GameObject[] GameObjectList;
    public int selectedCharacter = 0;
    private Button yourButton;
    private bool isCanvasActive;
    private bool isCarOneActive, isCarTwoActive;

    void Start()
    {

    }

    void Update()
    {
        if (isCarOneActive)
        {
            GameObjectList[0].SetActive(true);
            GameObjectList[1].SetActive(false);
        }
        else if(isCarTwoActive)
        {
            GameObjectList[0].SetActive(false);
            GameObjectList[1].SetActive(true);
        }
    }
    public void SetActiveCar(string buttonName)
    {
        Debug.Log(buttonName);
        if (buttonName == "CarOne")
        {
            isCarOneActive = true;
            isCarTwoActive = false;

        }
        else
        {
            isCarOneActive = false;
            isCarTwoActive = true;

        }
    }

    public void SetCanvasActive(bool canvasActive)
    {
        isCanvasActive = canvasActive;
    }

}

