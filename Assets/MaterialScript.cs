using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialScript : MonoBehaviour
{

    public Sprite selectedSprite;
    public Sprite unselectedSprite;
    public Button but;
    public void ChangeImage(int num)
    {
        if (num == 0)
            but.image.sprite = selectedSprite;
        else
        {
            but.image.sprite = unselectedSprite;
        }
    }
}
