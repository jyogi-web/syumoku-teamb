using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDisplayConclusion : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI conclusion;
    [SerializeField,TextArea(1,2)] string[] texts;//Unity��œ��͂���string�̔z��
    int textNumber;//���Ԗڂ�texts[]��\�������邩
    string displayText;//�\��������string
    int textCharNumber;//�������ڂ�displayText�ɒǉ����邩
    int displayTextSpeed; //�S�̂̃t���[�����[�g�𗎂Ƃ��ϐ�
    bool click;//�N���b�N����
    bool textStop; //�e�L�X�g�\�����n�߂邩
    void Update()
    {
        if (textStop == false) //�e�L�X�g��\��������if��
        {
            displayTextSpeed++;
            if (displayTextSpeed % 3 == 0)//�T��Ɉ��v���O���������s����if��
            {

                if (textCharNumber != texts[textNumber].Length)//����text[textNumber]�̕�����̕������Ō�̕�������Ȃ����
                {
                    displayText = displayText + texts[textNumber][textCharNumber];//displayText�ɕ�����ǉ����Ă���
                    textCharNumber = textCharNumber + 1;//���̕����ɂ���
                }
                else//����text[textNumber]�̕�����̕������Ō�̕�����������
                {
                    if (textNumber != texts.Length - 1)//����texts[]���Ō�̃Z���t����Ȃ��Ƃ���
                    {
                        if (click == true)//�N���b�N���ꂽ����
                        {
                            displayText = "";//�\�������镶���������
                            textCharNumber = 0;//�����̔ԍ����ŏ��ɂ���
                            textNumber = textNumber + 1;//���̃Z���t�ɂ���
                        }
                    }
                    else //����texts[]���Ō�̃Z���t�ɂȂ�����
                    {
                        if (click == true) //�N���b�N���ꂽ����
                        {
                            displayText = ""; //�\�������镶���������
                            textCharNumber = 0; //�����̔ԍ����ŏ��ɂ���
                            textStop = true; //�Z���t�\�����~�߂�
                            SceneManager.LoadScene("TutrioalAnimationGatya 1");
                        }
                    }
                }

                conclusion.text = displayText.ToString();
                //this.GetComponent<Text>().text = displayText;//��ʏ��displayText��\��
                click = false;//�N���b�N���ꂽ���������
            }
            if (Input.GetMouseButton(0))//�}�E�X���N���b�N������
            {
                click = true; //�N���b�N���ꂽ����ɂ���
            }
        }
    }
}