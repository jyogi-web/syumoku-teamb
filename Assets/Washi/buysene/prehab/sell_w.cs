using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sell_w : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    public int i;
    public void momo()
    {
        
        if((firebird.complete[i,5]-1)>=0){
            firebird.complete[i,5]-=1;
            firebird.money+=firebird.complete[i,4];
        }
        else
        {
            print("残高不足");
        }
        
    }

}
