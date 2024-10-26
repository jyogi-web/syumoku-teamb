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
            selectText.text = "‚»‚ê‚Í‚Ú‚ñ‚¶‚è‚¶‚á‚È‚¢‚¼";

        }
    }

    public void SelectB()
    {
        if (tutrial_hakaseserifu.isTextEnd)
        {
            selectText.text = "‚»‚ê‚Í‚Ú‚ñ‚¶‚è‚¶‚á‚È‚¢‚¼";

        }
    }
}