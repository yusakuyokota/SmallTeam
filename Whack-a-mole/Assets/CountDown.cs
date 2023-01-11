using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text textCountDown;

    public Image imageMask;

    public AudioClip whistle;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
        audioSource.PlayOneShot(whistle);
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "2";
        audioSource.PlayOneShot(whistle);
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "1";
        audioSource.PlayOneShot(whistle);
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "スタート";
        audioSource.PlayOneShot(whistle);
        yield return new WaitForSeconds(1.0f);

        textCountDown.text = "";
        imageMask.gameObject.SetActive(false);
    }
}
