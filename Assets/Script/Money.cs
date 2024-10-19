using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text balanceText; //�c����\������UI
    private int balance = 1000; //�c���̒l
    void Update()
    {
        UpdateBalanceText();

    }

    void UpdateBalanceText()
    {
        balanceText.text = "�c��: " + balance.ToString() + "�~";
    }

    public void SetBalance(int newBalance)
    {
        balance = newBalance;
        UpdateBalanceText();
    }

}