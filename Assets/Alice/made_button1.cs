using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class made_button1 : MonoBehaviour
{
    public GameObject canvas;
    //pa-tuhairetu
    public GameObject MomoSingle;
    public GameObject egg;
    public GameObject bonjiri;
    public GameObject butabara;
    public GameObject ginnan;
    public GameObject hatu;
    public GameObject furisode;
    public GameObject kasira;
    public GameObject Top3;
    public GameObject autumnspecial;
    public GameObject[] gameObjects;
    public int i=0;
    public int column=0;
    public int row=0;
    public static int[] x = new int[5]
    {
        80, 160, 240, 320, 400 
    };
    public static int[] y = new int[2]
    {
        200,100
    };
    void Start()
    {
        // 配列にcanvasとmomoを追加
        gameObjects = new GameObject[] {MomoSingle,egg,bonjiri,butabara,ginnan,hatu,furisode,kasira,Top3,autumnspecial};

        // 配列内の各GameObjectを処理
        foreach (GameObject obj in gameObjects)
        {
            // ここで各GameObjectに対する処理を行う
            GameObject prefab = (GameObject)Instantiate(obj);
            prefab.transform.SetParent(canvas.transform,false);
            // 必要に応じて座標を設定
            
            prefab.transform.position = new Vector3(x[column], y[row], 0);
            

            column++;

            if (column >= 5)
            {
                column = 0;
                row++;
            }
        }
    }
}
