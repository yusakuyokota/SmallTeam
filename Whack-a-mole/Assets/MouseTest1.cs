using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseTest1 : MonoBehaviour
{
    public GameObject Mouse;
    private float SpriteTimer = 0;
    private bool MouseCheck = false;

    public int Score = 0;

    public int get = 0;
    private Animator anim;

    [SerializeField] Image image;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [SerializeField] Sprite sprite3;
    private int Rand;

    private float ClickTimer;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        ClickTimer = 2;
        flag = false;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {    
        if (get == 2)
        {
            anim.SetBool("New Bool", true);
            SpriteTimer = 0;
            MouseCheck = true;
            get = 0;
        }

        ClickTimer -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            if (!flag)
            {
                Score = ScoreSet();

                flag = true;
                ClickTimer = 2;

                HandScore();
            }
        }

        if (MouseCheck) SpriteTimer += Time.deltaTime;

        if (SpriteTimer >= 3.5f)
        {
            MouseCheck = false;
            SpriteTimer = 0;
            Mouse.gameObject.SetActive(false);
            anim.SetBool("New Bool", false);
            SetSprite();
            flag = false;
            get = 0;
        }

    }

    void SetSprite()
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
            SetScore = 120;
        }
        else if (image.sprite == sprite2)
        {
            SetScore = 100;
        }
        else if (image.sprite == sprite3)
        {
            SetScore = 150;
        }
        
        return SetScore;
    }

    void HandScore()
    {
        ScoreManager scoremanager;
        GameObject obj = GameObject.Find("Score");
        scoremanager = obj.GetComponent<ScoreManager>();
        scoremanager.getScore = Score;
    }
}
