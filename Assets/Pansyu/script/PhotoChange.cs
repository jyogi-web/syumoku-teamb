using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoChange : MonoBehaviour
{
    private Image img;



    void Start()
    {
        img = GameObject.Find("Image").GetComponent<Image>();
    }

    public void Next()
    {
        zukan_No.score+=1;
        
        if (zukan_No.score > 22)
        {
            zukan_No.score = 0;
        }
            
        if (firebird.complete[zukan_No.score, 0] == 1)
        {
            img.sprite = Resources.Load<Sprite>("Image/photo" + zukan_No.score.ToString());
        }
        else
        {
            img.sprite = Resources.Load<Sprite>("Image/photo24");
        }
    }

    public void Back()
    {
        if((zukan_No.score) == 0)
        {
            zukan_No.score = 22;

        }
        else
        {
            zukan_No.score -= 1;
        }
        

        if (firebird.complete[zukan_No.score, 0] == 1)
        {
            img.sprite = Resources.Load<Sprite>("Image/photo" + zukan_No.score.ToString());
        }
        else
        {
            img.sprite = Resources.Load<Sprite>("Image/photo24");
        }
    }
}