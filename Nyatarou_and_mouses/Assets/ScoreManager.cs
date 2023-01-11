using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null;
    public static int TotalScore = 0;
    public int getScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (getScore != 0)
        {
            TotalScore += getScore;
            getScore = 0;
        }
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "" + TotalScore;
    }
}
