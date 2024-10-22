using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEmanager : MonoBehaviour
{
    public static AudioSource audiosourse;
    [SerializeField] AudioClip moneySE;
    // Start is called before the first frame update
    void Start()
    {
        audiosourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playmoneySE()
    {
        audiosourse.PlayOneShot(moneySE);
    }
}
