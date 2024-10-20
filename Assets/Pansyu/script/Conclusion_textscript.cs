using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conclusion_textscript: MonoBehaviour
{
    string[] message = {"うむ、これでひととおり終わったな!!","この基本を抑えて行動すれば君も焼き鳥マスターになれるはずじゃ!!"
            ,"それでは、","目指せ!!焼き鳥マスター!!!"};
    int messageNUM = 0;
    Text Text_;
    void Start()
    {
        Text_ = GetComponent<Text>();
        Text_.text = message[0];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            messageNUM++;
            Text_.text = message[messageNUM];
        }
    }
}
