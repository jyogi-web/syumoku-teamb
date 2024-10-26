using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // これを追加
public class caruto : MonoBehaviour
{
    public Text myText;
    public  int i;
    void Update()
    {
        myText.text = firebird.parts_name[i]+"串\n在庫"+firebird.complete[i,5].ToString()+"\n値段　"+firebird.complete[i,4]+"円";
    }
}
