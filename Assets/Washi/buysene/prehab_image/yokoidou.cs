using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalMove(new Vector3(5, 1.5f, 0),1.5f)
            .SetLoops(-2,LoopType.Incremental);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
