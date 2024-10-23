using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class riaizu_font7 : MonoBehaviour
{
    public Text myText;
    private firebird firebird;
    void Update()
    {
        myText.text = firebird.parts_name[7]+"\n在庫"+firebird.parts[7,2].ToString();
    }

}
