using System.Collections.Generic;
using UnityEngine;

public class DereatText : MonoBehaviour
{
    public void AllDestroy()
    {
        // "dereat text" タグのオブジェクトを取得
        GameObject[] ballsText = GameObject.FindGameObjectsWithTag("dereat text");
        // "dereat cap" タグのオブジェクトを取得
        GameObject[] ballsCap = GameObject.FindGameObjectsWithTag("dereat cap");

        // すべての "dereat text" タグのオブジェクトを破壊
        foreach (GameObject ball in ballsText)
        {
            Destroy(ball);
        }

        // すべての "dereat cap" タグのオブジェクトを破壊
        foreach (GameObject ball in ballsCap)
        {
            Destroy(ball);
        }
    }
}
