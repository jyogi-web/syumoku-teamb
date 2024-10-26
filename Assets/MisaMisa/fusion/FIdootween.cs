using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FIdootween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalMove(new Vector3(210, 40, 0), 1f)
            .SetLoops(-3, LoopType.Incremental);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
