using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiketto_w : MonoBehaviour
{
    public Text myText;

    // Update is called once per frame
    void Update()   
    {
        myText.text = 　"チケット　"+random_resipi.gatyatike+"枚";
    }
}
