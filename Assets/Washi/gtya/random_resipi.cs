using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_resipi : MonoBehaviour
{
    public int singlegath;
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
    void Update()
    {
        
    }
    public void nomalgath()
    {
        singlegath  = Random.Range(0, 19);
        if(firebird.complete[singlegath,0]==1)
        {
            Instantiate(nomal, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(gald, new Vector3(0, 0, 0), Quaternion.identity);
        }

        firebird.complete[singlegath,0]=1;
        print(singlegath);
    }
    public void tengath()
    {
        for (int i=0;i<10;i++)
        {
            fulag_chicken[i]=Random.Range(0, 20);
            //フラグ追加処理
            firebird.complete[fulag_chicken[i],0]=1;
            //生成処理
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
