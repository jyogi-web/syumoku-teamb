using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buy_shop : MonoBehaviour
{
    public int[] test = { 1, 2, 3, 4, 5 ,6,7,8,9,10};
    public GameObject momo;
    public GameObject egg;
    public GameObject canvas;
    //ボタン処理
    void botansistem()
    {
        

    }

    // Update is called once per frame
    void Start()
    {
        
        GameObject prefab =(GameObject)Instantiate(momo);
        botansistem();
        //GameObject prefab =(GameObject)Instantiate(egg);
        //botansistem();
        for(int i=0;i<10;i++)
        {
            //prefab_test[i].transform.SetParent(canvas.transform,false);
            //prefab_test[i].transform.position = new Vector2(-7, 0);
        }
    }
}
