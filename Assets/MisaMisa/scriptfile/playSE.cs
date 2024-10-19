using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSEbuttun()
    {
        SEmanager semanager = GameObject.Find("SEmanager").GetComponent<SEmanager>();
        semanager.playmoneySE();
    }
}

