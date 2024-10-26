using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour
{
    public Text myText;
    private firebird firebird;

    

    void Update()
    {
        myText.text = "残高 " + firebird.money.ToString() + " 円";
    }
}
