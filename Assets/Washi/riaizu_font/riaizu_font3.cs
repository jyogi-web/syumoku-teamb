using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class riaizu_font3 : MonoBehaviour
{
    public Text myText;
    private firebird firebird;
    void Update()
    {
        myText.text = firebird.parts_name[3]+"\n在庫"+firebird.parts[3,2].ToString();
    }

}
