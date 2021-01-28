using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageCanvas : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Testing123(string buttonName)
    {
        if(buttonName == "yes")
        {
            canvas.SetActive(true);
        }
    }
}
