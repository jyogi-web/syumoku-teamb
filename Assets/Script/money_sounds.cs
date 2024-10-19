using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money_sounds : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource moneysounds;
    void Start()
    {
         moneysounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        moneysounds.PlayOneShot(moneysounds.clip);
    }
}
