using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
    public GameObject negi;
    public GameObject torikawa;
    public GameObject[] gameObjects;
    public int k=0;
    public int column=0;
    public int row=0;
    public static int[] x = new int[5]
    {
        170, 250, 330, 410, 490 
    };
    public static int[] y = new int[2]
    {
        200,100
    };
    void Start()
    {
        System.Random random = new System.Random();
        // 配列にcanvasとmomoを追加
        // gameObjects = new GameObject[] {MomoSingle,egg,bonjiri,butabara,ginnan,hatu,furisode,kasira,negi,torikawa};

        // 配列内の各GameObjectを処理
        for(var j = 0; j < 2; j++)
      {
        for (var i = 0; i < 5; i++)
        {
            int rnd = random.Next(gameObjects.Length);
            // ここで各GameObjectに対する処理を行う
            GameObject prefab = (GameObject)Instantiate(gameObjects[rnd]);
            prefab.transform.SetParent(canvas.transform,false);
            // 必要に応じて座標を設定
            
            prefab.transform.position = new Vector3(x[i], y[j], 0);
            k++;
        }
      }
    }
}
