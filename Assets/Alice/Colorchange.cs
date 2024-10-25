using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Colorchange : MonoBehaviour
{
    [SerializeField]
UnityEngine.UI.Image image;

void Start()
{
	//1秒で赤色に変化し元の色に戻るのをずっと繰り返す
	this.image.DOColor(Color.red, 1f).SetLoops(-1,LoopType.Yoyo);
}

}

