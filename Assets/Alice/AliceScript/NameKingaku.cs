using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI要素を使用するために必要

public class NameKingaku : MonoBehaviour
{

    // Textコンポーネントをアタッチ
    public Text itemText;

    void Start()
    {
        // 配列から名前と価格を取得してテキストに表示
        UpdateItemText();
    }

    void UpdateItemText()
    {
        string displayText = "";
        for (int i = 0; i < firebird.parts_name.Length; i++)
        {
            displayText += firebird.parts_name[i] +"\n" + " - 価格: " + firebird.parts[i,1] + "円\n";
        }
        // Text UIに反映
        itemText.text = displayText;
    }

    void Momo()
    {
        itemText.text = firebird.parts_name[0] + "- 価格: " + firebird.parts[0,1] + "円\n";
    }

    void Tamago()
    {
        itemText.text = firebird.parts_name[1] + "- 価格: " + firebird.parts[1,1] + "円\n"; 
    }
}
