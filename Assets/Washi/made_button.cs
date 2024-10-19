using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class made_button : MonoBehaviour
{
    public GameObject canvas;
    //pa-tuhairetu
    public GameObject momo;
    public GameObject egg;
    public GameObject[] gameObjects;
    public int x=0;
    public int y=0;
    public int z=0;

    void Start()
    {
        // 配列にcanvasとmomoを追加
        gameObjects = new GameObject[] {momo,egg};

        // 配列内の各GameObjectを処理
        foreach (GameObject obj in gameObjects)
        {
            // ここで各GameObjectに対する処理を行う
            GameObject prefab = (GameObject)Instantiate(obj);
            prefab.transform.SetParent(canvas.transform,false);
            // 必要に応じて座標を設定
            
            prefab.transform.position = new Vector3(x, y, z);
        }
    }
}
