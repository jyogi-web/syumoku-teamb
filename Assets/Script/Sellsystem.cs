using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sellsystem :  MonoBehaviour
{

   public void momogusi()
    {
       firebird.complete[0,5] -= 1;
       firebird.money += firebird.complete[0,4]; 
    }

    public void torikawa()
    {
        firebird.complete[1,5] -= 1;
        firebird.money += firebird.complete[1,4];
    }

    public void butabara()
    {
        firebird.complete[2,5] -= 1;
        firebird.money += firebird.complete[2,4];
    }

    public void tukune()
    {
        firebird.complete[3,5] -= 1;
        firebird.money += firebird.complete[3,4];
    }

    public void momoniku()
    {
        firebird.complete[4,5] -= 1;
        firebird.money += firebird.complete[4,4];
    }

    public void sunagimo()
    {
        firebird.complete[5,5] -= 1;
        firebird.money += firebird.complete[5,4];
    }

    public void uzuraegg()
    {
        firebird.complete[6,5] -= 1;
        firebird.money += firebird.complete[6,4];
    }

    public void liver()
    {
        firebird.complete[7,5] -= 1;
        firebird.money += firebird.complete[7,4];
    }

    public void Top3()
    {
        firebird.complete[8,5] -= 1;
        firebird.money += firebird.complete[8,4];
    }

    public void autumnspecial()
    {
        firebird.complete[9,5] -= 1;
       firebird.money += firebird.complete[9,4];
    }

}
