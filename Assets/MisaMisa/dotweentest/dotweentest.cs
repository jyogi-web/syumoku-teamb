using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;


public class dotweentest : MonoBehaviour
{
    [SerializeField]
    float a_color = 255;
    [SerializeField]TextMeshProUGUI Tmp;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalMove(new Vector3(210, 40, 0), 1f);
        StartCoroutine("Flashing");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            Tmp.color = Tmp.color - new Color32(0, 0, 0, 2);

            yield return new WaitForSeconds(0.005f);

            if (a_color < 0)
            {
                a_color = 0;
                Destroy(this.gameObject);
            }
        }
        
    }
}
