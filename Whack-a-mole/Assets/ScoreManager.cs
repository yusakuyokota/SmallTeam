using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null;
    public int TotalScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "Score" + TotalScore;
    }
}
