using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseManager : MonoBehaviour
{
    public GameObject Mouse;
    private float Interval = 0.0f;
    bool Check = true;

    public int Score = 0;

    [SerializeField] Image image;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [SerializeField] Sprite sprite3;
    private int Rand;

    // Start is called before the first frame update
    void Start()
    {
        Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Score += ScoreSet();

            Mouse.gameObject.SetActive(false);
            Check = false;
            Interval = 0.0f;
            
            Random();
        }

        if (!Check) Interval += Time.deltaTime;

        if (Interval >= 3.0f)
        {
            Mouse.gameObject.SetActive(true);
            Check = true;
        }
        
        HandScore();
    }

    void Random()
    {
        Rand = UnityEngine.Random.Range(0, 3);
        if (Rand >= 2)
        {
            image.sprite = sprite1;
        }
        else if (Rand >= 1)
        {
            image.sprite = sprite2;
        }
        else if (Rand >= 0)
        {
            image.sprite = sprite3;
        }
    }

    int ScoreSet()
    {
        int SetScore = 0;

        if (image.sprite == sprite1)
        {
            SetScore = 30;
        }
        else if (image.sprite == sprite2)
        {
            SetScore = 15;
        }
        else if (image.sprite == sprite3)
        {
            SetScore = 60;
        }
        
        return SetScore;
    }

    void HandScore()
    {
        ScoreManager scoremanager;
        GameObject obj = GameObject.Find("Score");
        scoremanager = obj.GetComponent<ScoreManager>();
        scoremanager.TotalScore = Score;
    }
}
