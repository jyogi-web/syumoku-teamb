using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusion_cine : MonoBehaviour
{
    //public GameObject canvas;
    //public GameObject Scroll_View;
    //public GameObject Viewport;
    public GameObject Content;
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
    public int y=0;
    public int z=0;
    public static float[] x = new float[10]
        {
            -1,-2,-3,-4, -5, -6, 300, 380, 460, 540
        };

    // Start is called before the first frame update
    void Start()
    {

    
        gameObjects = new GameObject[] {momo,egg,bonjiri,butabara,ginnan,hatu,furisode,kasira};
        foreach (GameObject obj in gameObjects)
        {
            // ここで各GameObjectに対する処理を行う
            GameObject prefab = (GameObject)Instantiate(obj);
            //prefab.transform.SetParent(canvas.transform,false);
            //prefab.transform.SetParent(Scroll_View.transform,false);
            //prefab.transform.SetParent(Viewport.transform,false);
            //prefab.transform.SetParent(Content.transform,false);
            // 必要に応じて座標を設定
            prefab.transform.SetParent(Content.transform,false);
            prefab.transform.position = new Vector3(x[i], -7, z);
            i+=1;
        }
    }

    void Update()
    {
        //合成ボタン処理
        //if(firebird.chose_srotto[0]==4)
        //{
            //print("4");
        //}
    }

}
