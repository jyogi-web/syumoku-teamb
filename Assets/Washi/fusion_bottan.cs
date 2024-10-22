using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class fusion_bottan : MonoBehaviour
{
    //プレハブから持ってくるオブジェクト
    public GameObject bonjiriparts;
    //生成する位置
    public Transform surottoPos_1;
    public Transform surottoPos_2;
    public Transform surottoPos_3;
    public Transform surottoPos_4;
    //タグ作成

    //タグ削除処理
    void DeleteObjects()
    {
        GameObject[] objectsToDelete = GameObject.FindGameObjectsWithTag("yakipa");

        foreach (GameObject obj in objectsToDelete)
        {
            Destroy(obj);
        }
    }
    //スロットボタン処理

    public void chosesrotto_1()
    {
        firebird.chose_srotto[0]=0;
        print(firebird.chose_srotto[0]);
    }
    public void chosesrotto_2()
    {
        firebird.chose_srotto[0]=1;
        print(firebird.chose_srotto[0]);
    }
    public void chosesrotto_3()
    {
        firebird.chose_srotto[0]=2;
        print(firebird.chose_srotto[0]);
    }
    public void chosesrotto_4()
    {
        firebird.chose_srotto[0]=3;
        print(firebird.chose_srotto[0]);
    }
    //合体ボタン
    public void union()
    {
        if (firebird.chose_srottopage[0] == 0 || firebird.chose_srottopage[1] == 0 || firebird.chose_srottopage[2] == 0)
        {
            print("スロットが埋まってないよ！");
        }
        else
        {
            //for (int i = 0; i < firebird.chekk.GetLength(1); i++)
            //{
                for (int r = 0; r <10 ; r++)
                {
                    int trueCount = 0;
                    for(int j=0;j<3; j++)
                    {
                        if (firebird.chekk[r,j] == firebird.chose_srottopage[j])
                        {
                            trueCount++;
                        }
                    }
                    if (trueCount == 3) // 3回連続で true の場合
                    {
                        // スクリプトを実行
                        print("3回連続で一致しました！");
                        firebird.chose_srottopage = Enumerable.Repeat(0,3).ToArray();
                        // 必要な処理をここに追加
                        firebird.complete[r,5]+=1;
                        print(firebird.complete[r,5]);
                        DeleteObjects();
                    }
                    
                    
            
                }
            //}
        }
    }

    public void setti_bonjiri()
    {
        if(firebird.parts[2,2]>0)
        {
            
            if(firebird.chose_srotto[0]==4)
            {
                print("スロットがいっぱい！");
            }
            else
            {
                print("ぼんじりクリック");
                //スロット１に追加
                if(firebird.chose_srotto[0]==0)
                {
                    if(firebird.chose_srottopage[0]==2)
                    {
                        print("ぼんじりがあるよ");
                    }
                    else
                    {
                        firebird.chose_srottopage[0]=2;
                        Instantiate(bonjiriparts, surottoPos_1.position, surottoPos_1.rotation);
                        print("スロット１にぼんじり");
                        firebird.parts[2,2]-=1;
                    }
                    
                }
                if(firebird.chose_srotto[0]==1)
                {
                    if(firebird.chose_srottopage[1]==2)
                    {
                        print("ぼんじりがあるよ");
                    }
                    else
                    {
                        firebird.chose_srottopage[1]=2;
                        Instantiate(bonjiriparts, surottoPos_2.position, surottoPos_2.rotation);
                        print("スロット2にぼんじり");
                        firebird.parts[2,2]-=1;
                    }
                }
                if(firebird.chose_srotto[0]==2)
                {
                    if(firebird.chose_srottopage[2]==2)
                    {
                        print("ぼんじりがあるよ");
                    }
                    else
                    {
                        firebird.chose_srottopage[2]=2;
                        Instantiate(bonjiriparts, surottoPos_3.position, surottoPos_3.rotation);
                        print("スロット3にぼんじり");
                        firebird.parts[2,2]-=1;
                    }
                }
            }
            
        }
        else
        {
            print("ぼんじり在庫なし");
            
        }
        
        
    }



}
