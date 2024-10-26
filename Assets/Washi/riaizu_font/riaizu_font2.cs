using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class riaizu_font2 : MonoBehaviour
{
    public Text myText;
    private firebird firebird;
    void Update()
    {
        myText.text = firebird.parts_name[2]+"\n在庫"+firebird.parts[2,2].ToString();
    }

}
