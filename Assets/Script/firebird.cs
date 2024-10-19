using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebird : MonoBehaviour
{

    //現在の所持金
    public int money;
    //完成焼き鳥二次配列及び値段
    public static int[,] complete = new int[10, 6]
    {
        {1,1,2,3,120,0},
        {2,1,2,3,120,0},
        {3,1,2,3,120,0},
        {4,1,2,3,120,0},
        {5,1,2,3,120,0},
        {6,1,2,3,120,0},
        {7,1,2,3,120,0},
        {8,1,2,3,120,0},
        {9,1,2,3,120,0},
        {10,1,2,3,120,0}
    };

    public static int[,] parts = new int[10, 3]
    {
        {1,30,0},
        {2,30,0},
        {3,30,0},
        {4,30,0},
        {5,30,0},
        {6,30,0},
        {7,30,0},
        {8,30,0},
        {9,30,0},
        {10,30,0}
    };
}
