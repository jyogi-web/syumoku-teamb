using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoChange : MonoBehaviour
{
    private Image img;

    private int count = 1;


    void Start()
    {
        img = GameObject.Find("Image").GetComponent<Image>();
    }

    public void Next()
    {
        count++;
        PageCount.text = count.ToString();
        if (count >= 24)
            count = 1;
        if (firebird.complete[count,0] == 1)
        {
            img.sprite = Resources.Load<Sprite>("Image/photo" + count.ToString());
        }
        else
        {
            img.sprite = Resources.Load<Sprite>("Image/photo24");
        }
    }

    public void Back()
    {
        count--;
        PageCount.text = count.ToString();
        if (count <= 0)
            count = 23;
        if (firebird.complete[count, 0] == 1)
        {
            img.sprite = Resources.Load<Sprite>("Image/photo" + count.ToString());
        }
        else
        {
            img.sprite = Resources.Load<Sprite>("Image/photo24");
        }
    }
}