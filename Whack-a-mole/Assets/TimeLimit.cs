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

    private bool speedUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
                if (!speedUp)
                {
                    MouseManager mouseManager;
                    GameObject obj = GameObject.Find("Mouse_1");
                    mouseManager = obj.GetComponent<MouseManager>();
                    mouseManager.TimeLimit = 1;
                }
            }
        }
        else if (countdown <= 0)
        {
            countdown = 0;
            imageMask.gameObject.SetActive(true);
            timeUpAni.SetBool("TimeUp", true);
            
            MousePick mousePick;
            GameObject obj = GameObject.Find("MouseControl");
            mousePick = obj.GetComponent<MousePick>();
            mousePick.temp = 1;
         }
    }
}
