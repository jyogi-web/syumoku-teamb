using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text balanceText; //残高を表示するUI
    private int balance = 1000; //残高の値
    void Update()
    {
        UpdateBalanceText();

    }

    void UpdateBalanceText()
    {
        balanceText.text = "残高: " + balance.ToString() + "円";
    }

    public void SetBalance(int newBalance)
    {
        balance = newBalance;
        UpdateBalanceText();
    }

}