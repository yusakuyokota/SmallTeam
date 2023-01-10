using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text textCountDown;

    public Image imageMask;

    void Start()
    {
        textCountDown.text = "";
        Invoke("Count", 1.0f);
    }

    public void Count()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        textCountDown.text = "3";
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "2";
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "1";
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "スタート";
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "";
        imageMask.gameObject.SetActive(false);
    }
}
