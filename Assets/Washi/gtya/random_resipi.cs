using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_resipi : MonoBehaviour
{
    public int singlegath;
    public int z;
    public int j;
    public Transform parentTran;
    public GameObject nomal;
    public GameObject gald;
    public GameObject momo;
    public GameObject egg;
    public GameObject bonjiri;
    public GameObject butabara;
    public GameObject ginnan;
    public GameObject hatu;
    public GameObject furisode;
    public GameObject kasira;
    public GameObject[] gameObjects;
    public int resipi_rest;
    public int con;
    public static int[] fulag_chicken = new int[] {0,0,0,0,0,0,0,0,0,0};
    public static float[] setti10Pos = new float[]{100f, 200f, 300f, 400f, 500f,0f, 0f, 0f, 0f, 0f};

    public void nomalgath()
    {
        if((firebird.money-50)>=0)
        {
            firebird.money-=50;
            singlegath  = Random.Range(0, 19);
            GameObject obj;

            if(firebird.complete[singlegath,0]==1)
            {
                obj = Instantiate(nomal, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
            {
                obj = Instantiate(gald, new Vector3(0, 0, 0), Quaternion.identity);
            }

            obj.transform.SetParent(parentTran);
            obj.transform.localPosition = new Vector3(setti10Pos[singlegath], 0f, 0f);

            firebird.complete[singlegath,0]=1;
            print(singlegath);
        }
        else
        {
            print("お金が足りないよ！");
        }
    }

    public void tengath()
    {
        if((firebird.money-450)>=0)
        {
            firebird.money-=450;
            for (int i=0;i<10;i++)
            {
                print(firebird.money);
                fulag_chicken[j]=Random.Range(0, 20);
                GameObject obj;

                if(i<5)
                {
                    z=200;
                }
                else
                {
                    z=100;
                }

                if(firebird.complete[fulag_chicken[j],0]==1)
                {
                    obj = Instantiate(nomal, new Vector3(setti10Pos[i], z, 0), Quaternion.identity);
                }
                else
                {
                    obj = Instantiate(gald, new Vector3(setti10Pos[i], z, 0), Quaternion.identity);
                }

                obj.transform.SetParent(parentTran);
                firebird.complete[fulag_chicken[j],0]=1;
                print(fulag_chicken[j]);
            }
        }
        else
        {
            print("お金が足りないよ！");
        }
    }

    void kakutei()
    {
        for (int i=0;i<20;i++)
        {
            if(firebird.complete[i,0]==0)
            {
                resipi_rest+=1;
            }
        }

        for(int r=0;r<20;r++)
        {
            if(firebird.complete[r,0]==0)
            {
                con+=1;
                if(resipi_rest==con)
                {
                    firebird.complete[r,0]=1;
                    //インスタンス生成処理
                }
            }
        }
    }
}
