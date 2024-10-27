using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zukan_No : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score=0;
    public Text myText;
    // Update is called once per frame
    void Update()
    {
        myText.text = score.ToString();
    }
}
