using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyfont0 : MonoBehaviour
{
    public Text myText;
    private firebird firebird;
    public int r;
    void Update()
    {
        myText.text = firebird.parts_name[r]+"\n値段 "+firebird.parts[r,1].ToString()+"円";
    }

}
