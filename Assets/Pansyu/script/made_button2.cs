using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class made_button2 : MonoBehaviour
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
    public GameObject negi;
    public GameObject torikawa;
    public GameObject[] gameObjects;
    public int k=0;
    public int column=0;
    public int row=0;
    public static int[] x = new int[5]
    {
        130, 210, 290, 370, 450 
    };
    public static int[] y = new int[2]
    {
        200,100
    };
    void Start()
    {
      
        // 配列にcanvasとmomoを追加
        gameObjects = new GameObject[] {MomoSingle,egg,bonjiri,butabara,ginnan,hatu,furisode,kasira,negi,torikawa};

        // 配列内の各GameObjectを処理
        for(var j = 0; j < 2; j++)
      {
        for (var i = 0; i < 5; i++)
        {
            // ここで各GameObjectに対する処理を行う
            GameObject prefab = (GameObject)Instantiate(gameObjects[k]);
            prefab.transform.SetParent(canvas.transform,false);
            // 必要に応じて座標を設定
            
            prefab.transform.position = new Vector3(x[i], y[j], 0);
            k++;
        }
      }
    }
}
