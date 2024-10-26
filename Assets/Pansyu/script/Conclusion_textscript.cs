using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conclusion_textscript: MonoBehaviour
{
    string[] message = {"���ށA����łЂƂƂ���I�������!!","���̊�{��}���čs������ΌN���Ă����}�X�^�[�ɂȂ��͂�����!!"
            ,"����ł́A","�ڎw��!!�Ă����}�X�^�[!!!"};
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
