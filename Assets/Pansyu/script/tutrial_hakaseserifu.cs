using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class tutrial_hakaseserifu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI selectText;
    
    [SerializeField] TextMeshProUGUI buy;
    public string[] texts;//Unity��œ��͂���string�̔z��
    int textNumber;//���Ԗڂ�texts[]��\�������邩
    string displayText;//�\��������string
    int textCharNumber;//�������ڂ�displayText�ɒǉ����邩
    int displayTextSpeed; //�S�̂̃t���[�����[�g�𗎂Ƃ��ϐ�
    bool click;//�N���b�N����
    bool textStop; //�e�L�X�g�\�����n�߂邩
    public static bool isTextEnd = false;//�e�L�X�g�\�����I����Ă��邩
    bool isFirst = false;
    bool isSecond = false;
    bool isThird = false;
    public int pushNum = 0;

    void Start()
    {

    }
    void Update()
    {
        if (textStop == false) //�e�L�X�g��\��������if��
        {
            displayTextSpeed++;
            if (displayTextSpeed % 10 == 0)//�T��Ɉ��v���O���������s����if��
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
                        if (textNumber == 1)
                        {
                            if (pushNum >= 3)//�~�K���U�J�����ꂽ��
                            {
                                displayText = ""; //�\�������镶���������
                                textCharNumber = 0; //�����̔ԍ����ŏ��ɂ���
                                textNumber = textNumber + 1;//���̃Z���t�ɂ���
                            }
                        }
                        else if (click == true)//�N���b�N���ꂽ����
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
                            isTextEnd = true;//�Z���t���I������t���O
                        }
                    }
                }

                buy.text = displayText.ToString();
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