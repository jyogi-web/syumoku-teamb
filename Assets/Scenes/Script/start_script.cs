using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_script : MonoBehaviour
{

    public void OnButtonClick()
    {
        // シーンをロード
        SceneManager.LoadScene("tutorial_introduce");
    }
}
