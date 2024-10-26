using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushNumadd : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject buyserifu;
    tutrial_hakaseserifu th;


    void Start()
    {
        buyserifu = GameObject.Find("buyserifu");
        th = buyserifu.GetComponent<tutrial_hakaseserifu>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pushbutton()
    {
        th.pushNum++;
        firebird.money -= firebird.parts[2,1];
    }


}
