using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_resipi : MonoBehaviour
{
    public int singlegath;
    public int z;
    public int j;
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
    public static float[] setti10Pos = new float[]{-7f, -3.5f, 0f, 3.5f, 7f,-7f, -3.5f, 0f, 3.5f, 7f};

    public void nomalgath()
    {
        if((firebird.money-50)>=0)
        {
            firebird.money-=50;
            singlegath  = Random.Range(0, 19);
            if(firebird.complete[singlegath,0]==1)
            {
                Instantiate(nomal, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(gald, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
        else
        {
            print("お金が足りないよ！");
        }

        firebird.complete[singlegath,0]=1;
        print(singlegath);
    }
    public void tengath()
    {
        if((firebird.money-450)>=0)
        {
            firebird.money-=450;
            {
                for (int i=0;i<10;i++)
                {
                    print(firebird.money);
                    fulag_chicken[j]=Random.Range(0, 20);
                    //フラグ追加処理
                    //生成処理
                    if(i<5)
                    {
                        z=2;
                    }
                    else
                    {
                        z=-2;
                    }
                    if(firebird.complete[fulag_chicken[j],0]==1)
                    {
                        
                        Instantiate(nomal, new Vector3(setti10Pos[i], z, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(gald, new Vector3(setti10Pos[i],z, 0), Quaternion.identity);
                    }
                    firebird.complete[fulag_chicken[j],0]=1;
                    print(fulag_chicken[j]);
                }
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
                    //インスタ
                    
                }
            }
        }
    }
    
}
