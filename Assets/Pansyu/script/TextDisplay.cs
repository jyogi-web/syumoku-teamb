using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayIntro : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI intro;
    public string[] texts;//Unity�ｽ�ｽﾅ難ｿｽ�ｽﾍゑｿｽ�ｽ�ｽstring�ｽﾌ配�ｽ�ｽ
    int textNumber;//�ｽ�ｽ�ｽﾔ目ゑｿｽtexts[]�ｽ�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ驍ｩ
    string displayText;//�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽstring
    int textCharNumber;//�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽﾚゑｿｽdisplayText�ｽﾉ追会ｿｽ�ｽ�ｽ�ｽ驍ｩ
    int displayTextSpeed; //�ｽS�ｽﾌのフ�ｽ�ｽ�ｽ[�ｽ�ｽ�ｽ�ｽ�ｽ[�ｽg�ｽ獅ﾆゑｿｽ�ｽﾏ撰ｿｽ
    bool click;//�ｽN�ｽ�ｽ�ｽb�ｽN�ｽ�ｽ�ｽ�ｽ
    bool textStop; //�ｽe�ｽL�ｽX�ｽg�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽn�ｽﾟるか
    void Start()
    {

    }
    void Update()
    {
        if (textStop == false) //�ｽe�ｽL�ｽX�ｽg�ｽ�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽif�ｽ�ｽ
        {
            displayTextSpeed++;
            if (displayTextSpeed % 5 == 0)//�ｽT�ｽ�ｽﾉ茨ｿｽ�ｽv�ｽ�ｽ�ｽO�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽs�ｽ�ｽ�ｽ�ｽif�ｽ�ｽ
            {

                if (textCharNumber != texts[textNumber].Length)//�ｽ�ｽ�ｽ�ｽtext[textNumber]�ｽﾌ包ｿｽ�ｽ�ｽ�ｽ�ｽﾌ包ｿｽ�ｽ�ｽ�ｽ�ｽ�ｽﾅ鯉ｿｽﾌ包ｿｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽﾈゑｿｽ�ｽ�ｽ�ｽ
                {
                    displayText = displayText + texts[textNumber][textCharNumber];//displayText�ｽﾉ包ｿｽ�ｽ�ｽ�ｽ�ｽﾇ会ｿｽ�ｽ�ｽ�ｽﾄゑｿｽ�ｽ�ｽ
                    textCharNumber = textCharNumber + 1;//�ｽ�ｽ�ｽﾌ包ｿｽ�ｽ�ｽ�ｽﾉゑｿｽ�ｽ�ｽ
                }
                else//�ｽ�ｽ�ｽ�ｽtext[textNumber]�ｽﾌ包ｿｽ�ｽ�ｽ�ｽ�ｽﾌ包ｿｽ�ｽ�ｽ�ｽ�ｽ�ｽﾅ鯉ｿｽﾌ包ｿｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ
                {
                    if (textNumber != texts.Length - 1)//�ｽ�ｽ�ｽ�ｽtexts[]�ｽ�ｽ�ｽﾅ鯉ｿｽﾌセ�ｽ�ｽ�ｽt�ｽ�ｽ�ｽ�ｽﾈゑｿｽ�ｽﾆゑｿｽ�ｽ�ｽ
                    {
                        if (click == true)//�ｽN�ｽ�ｽ�ｽb�ｽN�ｽ�ｽ�ｽ黷ｽ�ｽ�ｽ�ｽ�ｽ
                        {
                            displayText = "";//�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ髟ｶ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ
                            textCharNumber = 0;//�ｽ�ｽ�ｽ�ｽ�ｽﾌ番搾ｿｽ�ｽ�ｽ�ｽﾅ擾ｿｽ�ｽﾉゑｿｽ�ｽ�ｽ
                            textNumber = textNumber + 1;//�ｽ�ｽ�ｽﾌセ�ｽ�ｽ�ｽt�ｽﾉゑｿｽ�ｽ�ｽ
                        }
                    }
                    else //�ｽ�ｽ�ｽ�ｽtexts[]�ｽ�ｽ�ｽﾅ鯉ｿｽﾌセ�ｽ�ｽ�ｽt�ｽﾉなゑｿｽ�ｽ�ｽ�ｽ�ｽ
                    {
                        if (click == true) //�ｽN�ｽ�ｽ�ｽb�ｽN�ｽ�ｽ�ｽ黷ｽ�ｽ�ｽ�ｽ�ｽ
                        {
                            displayText = ""; //�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ髟ｶ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ
                            textCharNumber = 0; //�ｽ�ｽ�ｽ�ｽ�ｽﾌ番搾ｿｽ�ｽ�ｽ�ｽﾅ擾ｿｽ�ｽﾉゑｿｽ�ｽ�ｽ
                            textStop = true; //�ｽZ�ｽ�ｽ�ｽt�ｽ\�ｽ�ｽ�ｽ�ｽ�ｽ~�ｽﾟゑｿｽ
                        }
                    }
                }

                intro.text = displayText.ToString();
                //this.GetComponent<Text>().text = displayText;//�ｽ�ｽﾊ擾ｿｽ�ｽdisplayText�ｽ�ｽ\�ｽ�ｽ
                click = false;//�ｽN�ｽ�ｽ�ｽb�ｽN�ｽ�ｽ�ｽ黷ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ
            }
            if (Input.GetMouseButton(0))//�ｽ}�ｽE�ｽX�ｽ�ｽ�ｽN�ｽ�ｽ�ｽb�ｽN�ｽ�ｽ�ｽ�ｽ�ｽ�ｽ
            {
                click = true; //�ｽN�ｽ�ｽ�ｽb�ｽN�ｽ�ｽ�ｽ黷ｽ�ｽ�ｽ�ｽ�ｽﾉゑｿｽ�ｽ�ｽ
            }
        }
    }
}