using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickSelect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI selectText;

    public void SelectA()
    {
        if (tutrial_hakaseserifu.isTextEnd)
        {
            selectText.text = "����͂ڂ񂶂肶��Ȃ���";

        }
    }

    public void SelectB()
    {
        if (tutrial_hakaseserifu.isTextEnd)
        {
            selectText.text = "����͂ڂ񂶂肶��Ȃ���";

        }
    }
}