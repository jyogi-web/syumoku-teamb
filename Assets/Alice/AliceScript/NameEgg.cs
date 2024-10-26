using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameEgg : MonoBehaviour
{
    string[] message = { "卵\n価格 30円" };

    int messageNUM = 0;
    Text Text_;

    void Start()
    {
        Text_ = GetComponent<Text>();
        Text_.text = message[0];  // 初期メッセージを表示
    }

    void Update()
    {
        // マウスの左ボタンが押されたとき
        if (Input.GetMouseButtonDown(0))
        {
            messageNUM++;

            // 範囲チェックを行い、メッセージを表示
            if (messageNUM < message.Length)
            {
                Text_.text = message[messageNUM];
            }
            else
            {
                // 範囲外になったら初期状態に戻す
                messageNUM = 0;
                Text_.text = message[messageNUM];
            }
        }
    }
}
