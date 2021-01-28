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

    void Start()
    {
        GameObjectList[0].SetActive(false);
        GameObjectList[1].SetActive(false);
    }

    public void SetActiveCar(string buttonName)
    {
        Debug.Log(buttonName);
        if(buttonName == "CarOne")
        {
            GameObjectList[0].SetActive(true);
            GameObjectList[1].SetActive(false);
        }
        else
        {
            GameObjectList[0].SetActive(false);
            GameObjectList[1].SetActive(true);
        }
    }

    public void Testing1234(string buttonName)
    {
        Debug.Log(buttonName);
        if(isCanvasActive)
        {
            if (buttonName == "CarOne")
            {
                GameObjectList[0].SetActive(true);
                GameObjectList[1].SetActive(false);
            }
            else
            {
                GameObjectList[0].SetActive(false);
                GameObjectList[1].SetActive(true);
            }
        }
    }

    public void SetCanvasActive(bool canvasActive)
    {
        isCanvasActive = canvasActive;
    }

}

