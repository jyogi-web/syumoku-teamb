using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebird : MonoBehaviour
{

    //現在の所持金
    public static int money=1000;
    //完成焼き鳥二次配列及び値段
    public static int[,] complete = new int[10, 6]
    {
        {1,1,2,3,120,0},
        {2,1,2,3,120,0},
        {3,1,2,3,120,0},
        {4,1,2,3,120,0},
        {5,1,2,3,120,0},
        {6,1,2,3,120,0},
        {7,1,2,3,120,0},
        {8,1,2,3,120,0},
        {9,1,2,3,120,0},
        {10,1,2,3,120,0}
    };
    //sozai_hairetu
    public static int[,] parts = new int[20, 3]
    {
        {1,30,0},
        {2,30,0},
        {3,30,0},
        {4,30,0},
        {5,30,0},
        {6,30,0},
        {7,30,0},
        {8,30,0},
        {9,30,0},
        {10,30,0},
        {11,30,0},
        {12,30,0},
        {13,30,0},
        {14,30,0},
        {15,30,0},
        {16,30,0},
        {17,30,0},
        {18,30,0},
        {19,30,0},
        {20,30,0}
    };
    //nanbaringu
    public static string[] parts_name = new string[20]
    {
        "もも肉",
        "卵",
        "ぼんじり",
        "豚バラ",
        "豚バラ",
        "ぎんなん",
        "ハツ",
        "フリソデ",
        "カシラ",
        "皮むね肉",
        "なんこつ",
        "ネギ",
        "レバー",
        "ささみ",
        "せせり",
        "しいたけ",
        "砂ずり",
        "タン",
        "手羽先",
        "つくね"
    };

    //ボタン押した際の処理
    public void momoparts()
    {
        parts[0, 2] += 1;
        money -= parts[0, 1];
    }
    public void eggparts()
    {
        parts[1, 2] += 1;
        money -= parts[1, 1];
    }
    public void bonjiri_parts()
    {
        parts[2, 2] += 1;
        money -= parts[2, 1];
    }
    public void butabarag_parts()
    {
        parts[3, 2] += 1;
        money -= parts[3, 1];
    }
    public void ginnan_parts()
    {
        parts[4, 2] += 1;
        money -= parts[4, 1];
    }
    public void hatu_parts()
    {
        parts[5, 2] += 1;
        money -= parts[5, 1];
    }
    public void furisode_parts()
    {
        parts[6, 2] += 1;
        money -= parts[6, 1];
    }
    public void kasira_parts()
    {
        parts[7, 2] += 1;
        money -= parts[7, 1];
    }
    public void kawa_parts()
    {
        parts[8, 2] += 1;
        money -= parts[8, 1];
    }
    public void mune_parts()
    {
        parts[9, 2] += 1;
        money -= parts[9, 1];
    }
    public void nankotu_parts()
    {
        parts[10, 2] += 1;
        money -= parts[10, 1];
    }
    public void nwgi_parts()
    {
        parts[11, 2] += 1;
        money -= parts[11, 1];
    }
    public void reba_parts()
    {
        parts[12, 2] += 1;
        money -= parts[12, 1];
    }
    public void sasami_parts()
    {
        parts[13, 2] += 1;
        money -= parts[13, 1];
    }
    public void seseri_parts()
    {
        parts[14, 2] += 1;
        money -= parts[14, 1];
    }
    public void siitake_parts()
    {
        parts[15, 2] += 1;
        money -= parts[15, 1];
    }
    public void sunazuri_parts()
    {
        parts[16, 2] += 1;
        money -= parts[16, 1];
    }
    public void tann_parts()
    {
        parts[17, 2] += 1;
        money -= parts[17, 1];
    }
    public void tebasaki_parts()
    {
        parts[18, 2] += 1;
        money -= parts[18, 1];
    }
    public void tukune_parts()
    {
        parts[19, 2] += 1;
        money -= parts[2, 1];
    }
    
    
}
