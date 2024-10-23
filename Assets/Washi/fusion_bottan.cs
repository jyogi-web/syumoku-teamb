using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class fusion_bottan : MonoBehaviour
{
    //プレハブから持ってくるオブジェクト
    public GameObject part;
    public GameObject part1;
    public GameObject part2;
    //生成する位置
    public Transform surottoPos_1;
    public Transform surottoPos_2;
    public Transform surottoPos_3;
    public Transform surottoPos_4;
    //タグ作成

    //タグ削除処理
    void DeleteObjects()
    {
        GameObject[] yaki = GameObject.FindGameObjectsWithTag("yakipa");

        foreach (GameObject obj in yaki)
        {
            Destroy(obj);
        }
    }
    void DeleteObjects1()
    {
        GameObject[] yaki_1 = GameObject.FindGameObjectsWithTag("yakipa_1");
        foreach (GameObject obj in yaki_1)
        {
            Destroy(obj);
        }
    }
    void DeleteObjects2()
    {
        GameObject[] yaki_2 = GameObject.FindGameObjectsWithTag("yakipa_2");
        foreach (GameObject obj in yaki_2)
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
                            for (int i = 0; i < firebird.chose_srottopage.Length; i++)
                            {
                                print("chose_srottopage[" + i + "] = " + firebird.chose_srottopage[i]);
                            }
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
                        DeleteObjects1();
                        DeleteObjects2();
                        firebird.chose_srotto[0]=4;
                        
                    }
                    
                    
            
                }
            //}
        }
    }
    
    public void setti_egg(int r)
    {
        if(firebird.parts[r,2]>0)
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
                    if(firebird.chose_srottopage[0]==0)
                    {
                        firebird.chose_srottopage[0]=r+1;
                        Instantiate(part, surottoPos_1.position, surottoPos_1.rotation);
                        print("スロット１に");
                        firebird.parts[r,2]-=1;
                    }
                    else
                    {
                        if(firebird.chose_srottopage[0]==r+1)
                        {
                            print("もう入ってるよ");
                        }
                        else
                        {
                            firebird.parts[firebird.chose_srottopage[0]-1,2]+=1;
                            print("塗り替え");
                            DeleteObjects();
                            Instantiate(part, surottoPos_1.position, surottoPos_1.rotation);
                            firebird.parts[r,2]-=1;
                            firebird.chose_srottopage[0]=r+1;
                        }   
                    }
                }
                if(firebird.chose_srotto[0]==1)
                {
                    if(firebird.chose_srottopage[1]==0)
                    {
                        firebird.chose_srottopage[1]=r+1;
                        Instantiate(part1, surottoPos_2.position, surottoPos_2.rotation);
                        print("スロット2に");
                        firebird.parts[r,2]-=1;
                    }
                    else
                    {
                        if(firebird.chose_srottopage[1]==r+1)
                        {
                            print("もう入ってるよ");
                        }
                        else
                        {
                            firebird.parts[firebird.chose_srottopage[1]-1,2]+=1;
                            print("塗り替え");
                            DeleteObjects1();
                            Instantiate(part1, surottoPos_2.position, surottoPos_2.rotation);
                            firebird.parts[r,2]-=1;
                            firebird.chose_srottopage[1]=r+1;
                        }
                    }
                }
                if(firebird.chose_srotto[0]==2)
                {
                    if(firebird.chose_srottopage[2]==0)
                    {
                        firebird.chose_srottopage[2]=r+1;
                        Instantiate(part2, surottoPos_3.position, surottoPos_3.rotation);
                        print("スロット3に");
                        firebird.parts[r,2]-=1;
                    }
                    else
                    {
                        if(firebird.chose_srottopage[2]==r+1)
                        {
                            print("もう入ってるよ");
                        }
                        else
                        {
                            firebird.parts[firebird.chose_srottopage[2]-1,2]+=1;
                            print("塗り替え");
                            DeleteObjects2();
                            Instantiate(part2, surottoPos_3.position, surottoPos_3.rotation);
                            firebird.parts[r,2]-=1;
                            firebird.chose_srottopage[2]=r+1;
                        }
                    }
                }
            }
        }
        else
        {
            print("在庫なし");
        }
    }
}


