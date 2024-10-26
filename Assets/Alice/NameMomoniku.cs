using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameMomoniku : MonoBehaviour
{
    string[] message = {"もも肉\n価格 30円"};

    int messageNUM = 0;
    Text Text_;
    void Start()
    {
        Text_ = GetComponent<Text>();
        Text_. text = message[0];
    }
    void update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                messageNUM++;
            Text_.text = message[messageNUM];
        }
    }
        
}
