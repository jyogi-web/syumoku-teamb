using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class  Introduction_textscript : MonoBehaviour
{
    string[] message = {"���ށA�悭������!!���V���₫�Ƃ蔎�m��!", "�N�͏Ă����͍D����?�ˑR���Ⴊ�A���V�̌������N�Ɏ�`���Ăق����̂���B",
                "�����ȂƂ���𗷂��Ă�������̋�ނ��W�߁A�ǂ�ǂ�₫�Ƃ����������̂���!!!", "���ɏo��O�ɌN�ɊȒP�Ȓm���Ƃ�����������낤�B",
                "������̃v���[���g����! ���ꂩ�烏�V���N�Ɏ��葫��苳���邩�炵�����蕷���Ă����̂��Ⴜ!!!",
                "����ł͏o������!!" };
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