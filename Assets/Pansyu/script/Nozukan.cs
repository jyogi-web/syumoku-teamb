using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nozukan : MonoBehaviour
{
    public Text mytext;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        mytext.text ="No."+PhotoChange.count;
    }
}
