using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sellsystem : MonoBehaviour
{
    public void momogusi()
    {
        if (firebird.complete[0, 5] > 0) // 在庫があるか確認
        {
            firebird.complete[0, 5] -= 1; // 在庫を減らす
            firebird.money += firebird.complete[0, 4]; // 残高を増やす
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void torikawa()
    {
        if (firebird.complete[1, 5] > 0)
        {
            firebird.complete[1, 5] -= 1;
            firebird.money += firebird.complete[1, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void butabara()
    {
        if (firebird.complete[2, 5] > 0)
        {
            firebird.complete[2, 5] -= 1;
            firebird.money += firebird.complete[2, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void tukune()
    {
        if (firebird.complete[3, 5] > 0)
        {
            firebird.complete[3, 5] -= 1;
            firebird.money += firebird.complete[3, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void momoniku()
    {
        if (firebird.complete[4, 5] > 0)
        {
            firebird.complete[4, 5] -= 1;
            firebird.money += firebird.complete[4, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void sunagimo()
    {
        if (firebird.complete[5, 5] > 0)
        {
            firebird.complete[5, 5] -= 1;
            firebird.money += firebird.complete[5, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void uzuraegg()
    {
        if (firebird.complete[6, 5] > 0)
        {
            firebird.complete[6, 5] -= 1;
            firebird.money += firebird.complete[6, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void liver()
    {
        if (firebird.complete[7, 5] > 0)
        {
            firebird.complete[7, 5] -= 1;
            firebird.money += firebird.complete[7, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void Top3()
    {
        if (firebird.complete[8, 5] > 0)
        {
            firebird.complete[8, 5] -= 1;
            firebird.money += firebird.complete[8, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }

    public void autumnspecial()
    {
        if (firebird.complete[9, 5] > 0)
        {
            firebird.complete[9, 5] -= 1;
            firebird.money += firebird.complete[9, 4];
        }
        else
        {
            Debug.Log("在庫がありません！");
        }
    }
}
