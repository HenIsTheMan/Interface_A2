using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageCanvas : MonoBehaviour
{
    public GameObject canvas;
    private bool upgradeButton;
    private bool carIsSelected;
    // Start is called before the first frame update
    void Start()
    {
        upgradeButton = carIsSelected = false;
        //canvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       
        if(upgradeButton && !carIsSelected)
        {
            upgradeButton = false;
        }

        if (upgradeButton && carIsSelected)
        {
            canvas.SetActive(true);
        }
        else if(!upgradeButton || !carIsSelected )
        {
            canvas.SetActive(false);
        }
    }

    public void SetUpgradeButton(bool boolean)
    {
        upgradeButton = boolean;
    }

    public void SetCarSelected(bool boolean)
    {
        carIsSelected = boolean;
    }
    public void Testing123(string buttonName)
    {

        if(buttonName == "mustang" || buttonName == "mystic")
        {
            carIsSelected = true;
        }
        if(buttonName == "yes")
        {
            upgradeButton = true;
        }
        else if(buttonName == "no")
        {
            upgradeButton = false;
        }

        if (upgradeButton)
        {
            Debug.Log("upgrade is true");

        }
        else
        {
            Debug.Log("upgrade is false");
        }
        if (carIsSelected)
        {
            Debug.Log("car is true");
        }
        else
        {
            Debug.Log("car is false");
        }
    }
}
