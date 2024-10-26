using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yakiyotiLavel : MonoBehaviour
{
    Text label;
    public string name;
    public int y;
    public int x;

    // Start is called before the first frame update
    void Start()
    {
        label = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        label.text=name+"\n120円\n"+firebird.complete[y,x].ToString();
    }
}
