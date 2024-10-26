using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class gatyaburu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOShakePosition(1f, 5f, 30, 1, false, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
