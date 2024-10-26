using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalMove(new Vector3(220, 40, 0),1f)
            .SetLoops(-2,LoopType.Incremental);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
