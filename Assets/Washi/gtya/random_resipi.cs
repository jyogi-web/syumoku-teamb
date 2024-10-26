using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_resipi : MonoBehaviour
{
    public int singlegath;
    public int z;
    public int j;
    public GameObject red;
    public Transform parentTran;
    public GameObject haikei;
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
    public GameObject kawa;
    public GameObject muneniku;
    public GameObject nankotu;
    public GameObject negi;
    public GameObject reba;
    public GameObject sasami;
    public GameObject seseri;
    public GameObject siitake;
    public GameObject sunazuri;
    public GameObject tann;
    public GameObject tebasaki;
    public GameObject tukune;
    private GameObject[] gameObjects;
    public int resipi_rest;
    public int con;
    public static int[] fulag_chicken = new int[] {0,0,0,0,0,0,0,0,0,0};
    public static float[] setti10Pos = new float[]{100f, 200f, 300f, 400f, 500f,100f, 200f, 300f, 400f, 500f};

    public void nomalgath()
    {
        if((firebird.money-50)>=0)
        {
            firebird.money-=50;
            singlegath  = Random.Range(0, 19); // 修正
            GameObject obj;
            GameObject kabe;
            
            kabe=Instantiate(haikei, new Vector3(300, 200, 0), Quaternion.identity);
            kabe.transform.SetParent(parentTran);
            if(firebird.complete[singlegath,0]==1)
            {
                obj = Instantiate(red, new Vector3(300, 200, 0), Quaternion.identity);
            }
            else
            {
                obj = Instantiate(gameObjects[singlegath], new Vector3(300, 200, 0), Quaternion.identity);
            }

            obj.transform.SetParent(parentTran);
            //obj.transform.localPosition = new Vector3(setti10Pos[singlegath], 0f, 0f);

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
            GameObject kabe;
            kabe=Instantiate(haikei, new Vector3(300, 200, 0), Quaternion.identity);
            kabe.transform.SetParent(parentTran);
            for (int i=0;i<10;i++)
            {
                print(firebird.money);
                fulag_chicken[i]=Random.Range(0, 20); // 修正
                GameObject obj;

                if(i<5)
                {
                    z=200;
                }
                else
                {
                    z=100;
                }

                if(firebird.complete[fulag_chicken[i],0]==1) // 修正
                {
                    obj = Instantiate(red, new Vector3(setti10Pos[i], z, 0), Quaternion.identity);
                }
                else
                {
                    obj = Instantiate(gameObjects[fulag_chicken[i]], new Vector3(setti10Pos[i], z, 0), Quaternion.identity);
                }

                obj.transform.SetParent(parentTran);
                firebird.complete[fulag_chicken[i],0]=1; // 修正
                print(fulag_chicken[i]); // 修正
            }
        }
        else
        {
            print("お金が足りないよ！");
        }
    }
    void Start()
    {
        gameObjects = new GameObject[] {momo,egg,bonjiri,butabara,ginnan,hatu,furisode,kasira,kawa,muneniku,nankotu,negi,reba,sasami,seseri,siitake,sunazuri,tann,tebasaki,tukune};
    }
    public void kakutei()
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
                    GameObject kabe;
            
                    kabe=Instantiate(haikei, new Vector3(300, 200, 0), Quaternion.identity);
                    kabe.transform.SetParent(parentTran);
                    firebird.complete[r,0]=1;
                    GameObject obj;
                    obj = Instantiate(gameObjects[r], new Vector3(300, 200, 0), Quaternion.identity);
                    obj.transform.SetParent(parentTran);
                }
            }
        }
    }
}
