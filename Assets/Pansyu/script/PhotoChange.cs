using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoChange : MonoBehaviour
{
    private Image img;
    public static int count = 1;

    void Start()
    {
        img = GameObject.Find("Image").GetComponent<Image>();
    }

    public void Next()
    {
        count++;
        if (count >= 23)
            count = 1;

        img.sprite = Resources.Load<Sprite>("Image/photo" + count.ToString());
    }

    public void Back()
    {
        count--;
        Debug.Log(count);
        if (count <= 0)
            count = 22;

        img.sprite = Resources.Load<Sprite>("Image/photo" + count.ToString());
    }
}