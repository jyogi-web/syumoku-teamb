using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebird : MonoBehaviour
{

    //現在の所持金
    public static int money=1000;

    //フラグ
    public static bool fusion_page=false;
    
    public static bool momokusi=false;
    public static bool eggkusi=false;
    public static bool bonjirikusi=false;
    public static bool butabarakusi=false;
    public static bool ginnankusi=false;
    public static bool hatukusi=false;
    public static bool furisodekusi=false;
    public static bool kasirakusi=false;
    public static bool kawakusi=false;
    public static bool munenikukkusi=false;
    public static bool nankotukusi=false;
    public static bool negikusi=false;
    public static bool rebakusi=false;
    public static bool sasamikusi=false;
    public static bool seserikusi=false;
    public static bool siitakekusi=false;
    public static bool sunazurikusi=false;
    public static bool tankusi=false;
    public static bool tebasakikusi=false;
    public static bool tukunekusi=false;
    
    //選択しているスロットフラグ

    //完成焼き鳥二次配列及び値段
    public static int[,] complete = new int[23, 6]
    {
        {0,1,1,1,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,1,1,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {0,1,2,3,200,0},
        {1,1,2,3,200,0}
        
    };
    //確認用焼き鳥配列
    public static int[,] chekk = new int[23,3]
    {
        {1,1,1},
        {2,2,2},
        {3,3,3},
        {4,4,4},
        {5,5,5},
        {6,6,6},
        {7,7,7},
        {8,8,8},
        {9,9,9},
        {10,10,10},
        {11,11,11},
        {12,12,12},
        {13,13,13},
        {14,14,14},
        {15,15,15},
        {16,16,16},
        {17,17,17},
        {18,18,18},
        {19,19,19},
        {20,20,20},
        {21,21,21},
        {22,22,22},
        {22,22,22}


    };
    //素材配列
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
    //パーツナンバリング
    public static string[] parts_name = new string[20]
    {
        "もも肉",
        "卵",
        "ぼんじり",
        "豚バラ",
        "ぎんなん",
        "ハツ",
        "フリソデ",
        "カシラ",
        "皮",
        "むね肉",
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
    //串ナンバリング
    
    //合成スロット処理
    public static int[] chose_srotto = new int[]{5}; // 配列のサイズを4に設定

    // 選択しているスロットの管理(内部)
    public static int[] chose_srottopage = new int[] { 0, 0, 0 };
    
    //ボタン押した際の処理
    public void momoparts()
    {
        if((money-parts[0, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[0, 2] += 1;
            money -= parts[0, 1];
        }
        
        
    }
    public void eggparts()
    {
        if((money-parts[1, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[1, 2] += 1;
            money -= parts[1, 1];
        }
    }
    public void bonjiri_parts()
    {
        if((money-parts[2, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[2, 2] += 1;
            money -= parts[2, 1];
        }
    }
    public void butabarag_parts()
    {
        if((money-parts[3, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[3, 2] += 1;
            money -= parts[3, 1];
        }
    }
    public void ginnan_parts()
    {
        if((money-parts[4, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[4, 2] += 1;
            money -= parts[4, 1];
        }
    }
    public void hatu_parts()
    {
        if((money-parts[5, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[5, 2] += 1;
            money -= parts[5, 1];
        }
    }
    public void furisode_parts()
    {
        if((money-parts[6, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[6, 2] += 1;
            money -= parts[6, 1];
        }
    }
    public void kasira_parts()
    {
        if((money-parts[7, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[7, 2] += 1;
            money -= parts[7, 1];
        }
    }
    public void kawa_parts()
    {
        if((money-parts[8, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[8, 2] += 1;
            money -= parts[8, 1];
        }
    }
    public void mune_parts()
    {
        if((money-parts[9, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[9, 2] += 1;
            money -= parts[9, 1];
        }
    }
    public void nankotu_parts()
    {
        if((money-parts[10, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[10, 2] += 1;
            money -= parts[10, 1];
        }
    }
    public void nwgi_parts()
    {
        if((money-parts[11, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[11, 2] += 1;
            money -= parts[11, 1];
        }
    }
    public void reba_parts()
    {
        if((money-parts[12, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[12, 2] += 1;
            money -= parts[12, 1];
        }
    }
    public void sasami_parts()
    {
        if((money-parts[13, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[13, 2] += 1;
            money -= parts[13, 1];
        }
    }
    public void seseri_parts()
    {
        if((money-parts[14, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[14, 2] += 1;
            money -= parts[14, 1];
        }
    }
    public void siitake_parts()
    {
        if((money-parts[15, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[15, 2] += 1;
            money -= parts[15, 1];
        }
    }
    public void sunazuri_parts()
    {
        if((money-parts[16, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[16, 2] += 1;
            money -= parts[16, 1];
        }
    }
    public void tann_parts()
    {
        if((money-parts[17, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[17, 2] += 1;
            money -= parts[17, 1];
        }
    }
    public void tebasaki_parts()
    {
        if((money-parts[18, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[18, 2] += 1;
            money -= parts[18, 1];
        }
    }
    public void tukune_parts()
    {
        if((money-parts[19, 1])<0)
        {
            print("noマニー");
        }
        else
        {
            parts[19, 2] += 1;
            money -= parts[19, 1];
        }
    }
    
    //合成シーンのスロット追加処理
    
    
}
