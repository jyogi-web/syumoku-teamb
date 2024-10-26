using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class riaizu_font6 : MonoBehaviour
{
    public Text myText;
    private firebird firebird;
    void Update()
    {
        myText.text = firebird.parts_name[6]+"\n在庫"+firebird.parts[6,2].ToString();
    }

}
