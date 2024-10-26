using System.Collections.Generic;
using UnityEngine;

public class Dereat_cup : MonoBehaviour
{
    public void AllDestroy()
    {
        // "dereat text" タグのオブジェクトを取得
        GameObject[] ballsText = GameObject.FindGameObjectsWithTag("dereat text");
        // "dereat cap" タグのオブジェクトを取得

        // すべての "dereat text" タグのオブジェクトを破壊
        foreach (GameObject ball in ballsText)
        {
            Destroy(ball);
        }

        // すべての "dereat cap" タグのオブジェクトを破壊

    }
}
