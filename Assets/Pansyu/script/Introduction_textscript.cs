using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class  Introduction_textscript : MonoBehaviour
{
    string[] message = {"うむ、よく来たな!!ワシがやきとり博士だ!", "君は焼き鳥は好きか?突然じゃが、ワシの研究を君に手伝ってほしいのじゃ。",
                "いろんなところを旅してたくさんの具材を集め、どんどんやきとりを合成するのじゃ!!!", "旅に出る前に君に簡単な知識とお小遣いをやろう。",
                "私からのプレゼントじゃ! これからワシが君に手取り足取り教えるからしっかり聞いておくのじゃぞ!!!",
                "それでは出発じゃ!!" };
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