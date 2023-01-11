using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public AudioClip Click;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClickStart()
    {
        audioSource.PlayOneShot(Click);
        FadeManager.Instance.LoadScene("Synopsis", 0.3f);
    }

    public void OnClickBattleStart()
    {
        audioSource.PlayOneShot(Click);
        FadeManager.Instance.LoadScene("InGameScene", 0.3f);
    }

    public void OnClickRanking()
    {
        audioSource.PlayOneShot(Click);
        FadeManager.Instance.LoadScene("Ranking", 0.3f);
    }

    public void OnClickRetry()
    {
        audioSource.PlayOneShot(Click);
        FadeManager.Instance.LoadScene("InGameScene", 0.3f);
    }

    public void OnClickBackTitle()
    {
        audioSource.PlayOneShot(Click);
        FadeManager.Instance.LoadScene("TitleScene", 0.3f);
    }
}
