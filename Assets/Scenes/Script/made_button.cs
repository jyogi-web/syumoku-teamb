using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class made_button : MonoBehaviour
{
    public GameObject canvas;
    //pa-tuhairetu
    public GameObject momo;
    public GameObject egg;
    public GameObject bonjiri;
    public GameObject butabara;
    public GameObject ginnan;
    public GameObject hatu;
    public GameObject furisode;
    public GameObject kasira;
    public GameObject[] gameObjects;
    public int i=0;
    public int y=500;
    public int z=0;
    public static int[] x = new int[8]
    {
        80, 160, 240, 320, 400, 480, 560, 640
    };
    void Start()
    {
        // 配列にcanvasとmomoを追加
        gameObjects = new GameObject[] {momo,egg,bonjiri,butabara,ginnan,hatu,furisode,kasira};

        // 配列内の各GameObjectを処理
        foreach (GameObject obj in gameObjects)
        {
            // ここで各GameObjectに対する処理を行う
            GameObject prefab = (GameObject)Instantiate(obj);
            prefab.transform.SetParent(canvas.transform,false);
            // 必要に応じて座標を設定
            
            prefab.transform.position = new Vector3(x[i], 150, z);
            i+=1;
        }
    }
}
