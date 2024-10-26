using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject haikei;
    GameObject parentTran;

    void Start()
    {
        parentTran=GameObject.Find("Canvas");
    }
    public void momoniku()
    {
        GameObject kabe;
            
        kabe=Instantiate(haikei, new Vector3(0, 0, 0), Quaternion.identity);
        kabe.transform.SetParent(parentTran.transform,false);
    }
}
