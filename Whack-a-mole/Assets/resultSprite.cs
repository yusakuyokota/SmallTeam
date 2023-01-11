using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultSprite : MonoBehaviour
{
    public GameObject Result;

    [SerializeField] Image image;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [SerializeField] Sprite sprite3;
    [SerializeField] Sprite sprite4;
    [SerializeField] Sprite sprite5;

    public int Score = ScoreManager.TotalScore;

    int res1 = 950, res2 = 750, res3 = 400, res4 = 200, res5 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Score >= res1)
        {
            image.sprite = sprite1;
        }
        else if (Score >= res2)
        {
            image.sprite = sprite2;
        }
        else if (Score >= res3)
        {
            image.sprite = sprite3;
        }
        else if (Score >= res4)
        {
            image.sprite = sprite4;
        }
        else if (Score >= res5)
        {
            image.sprite = sprite5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
