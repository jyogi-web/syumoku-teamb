using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text balanceText; 
    private int check = 0;
    private int balance = 1000; 
    void Update()
    {
        UpdateBalanceText();
    }

    void UpdateBalanceText()
    {
        
        balance=firebird.money;
        
        if(0>balance)
        {
            firebird.money=check;
        }
        else
        {
            balanceText.text = "所持金" + balance.ToString() + "円";
        }
        firebird.money=balance;
    }

}