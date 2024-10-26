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
        Tmp.text = "";
        Tmp.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttunpush()
    {
        transform.DOLocalMove(new Vector3(210, 40, 0), 1f);
        StartCoroutine("Flashing");
    }

    IEnumerator Flashing()
    {
        Tmp.text = "-50";
        Tmp.color = Tmp.color+ new Color32(255, 224, 5, 255);
        while (true)
        {
            Tmp.color = Tmp.color - new Color32(0, 0, 0, 4);

            yield return new WaitForSeconds(0.01f);

            if (a_color < 0)
            {
                a_color = 0;
                Destroy(this.gameObject);
            }
        }
        
    }
}
