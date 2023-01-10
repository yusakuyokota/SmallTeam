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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
