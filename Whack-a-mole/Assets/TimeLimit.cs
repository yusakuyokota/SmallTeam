using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    public float countdown = 20.0f;

    private float StartCount = 0;

    public Text timeText;

    public Image imageMask;

    public Animator timeUpAni;

    public AudioClip whistle;
    AudioSource audioSource;

    private int speedUp = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StartCount <= 5.0f)
        {
            StartCount += Time.deltaTime;
        }
        else if (countdown > 0)
        {
            countdown -= Time.deltaTime;

            timeText.text = countdown.ToString("f2");

            if (countdown <= 10)
            {
                if (speedUp == 0)
                {
                    MouseManager mouseManager;
                    GameObject obj = GameObject.Find("Mouse_1");
                    mouseManager = obj.GetComponent<MouseManager>();
                    mouseManager.TimeLimit = 1;

                    speedUp++;
                    MousePick mousePick;
                    GameObject obj1 = GameObject.Find("MouseControl");
                    mousePick = obj1.GetComponent<MousePick>();
                    mousePick.span = 1f;
                }
            }
        }
        else if (countdown < 0)
        {
            countdown = 0;
            imageMask.gameObject.SetActive(true);
            timeUpAni.SetBool("TimeUp", true);
            Invoke("PlayWhistle", 0.5f);

            MousePick mousePick;
            GameObject obj = GameObject.Find("MouseControl");
            mousePick = obj.GetComponent<MousePick>();
            mousePick.temp = 1;
         }
    }

    void PlayWhistle()
    {
        audioSource.PlayOneShot(whistle);
    }
}
