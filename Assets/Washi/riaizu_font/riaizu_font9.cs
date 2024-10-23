using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class riaizu_font9 : MonoBehaviour
{
    public Text myText;
    private firebird firebird;
    void Update()
    {
        myText.text = firebird.parts_name[9]+"\n在庫"+firebird.parts[9,2].ToString();
    }

}
