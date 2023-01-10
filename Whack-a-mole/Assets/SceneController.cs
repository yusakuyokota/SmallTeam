using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public void OnClickStart()
    {
        FadeManager.Instance.LoadScene("InGameScene", 0.3f);
    }

    public void OnClickRanking()
    {
        FadeManager.Instance.LoadScene("Ranking", 0.3f);
    }
}
