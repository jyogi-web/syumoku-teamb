using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class okane : MonoBehaviour
{
    public Text myText; 
    


    // Update is called once per frame
    void Update()
    {
        myText.text = "所持金　"+firebird.money.ToString()+"円";
    }
}
