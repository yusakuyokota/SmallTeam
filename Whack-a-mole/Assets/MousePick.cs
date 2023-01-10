using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePick : MonoBehaviour
{
    public GameObject[] MouseBox = new GameObject[9];
    private float Interval = 0.5f;
    private float span = 1f;

    private int Rand;

    public int temp = 0;

    private float StartCount = 0;
    private float nextScene = 0;

    private bool End = false;

    // Start is called before the first frame update
    void Start()
    {
        SetMouse();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StartCount <= 5.0f)
        {
            StartCount += Time.deltaTime;
        }
        else if (temp == 1)
        {
            if (!End)
            { 
                Invoke("ToResult", 3f);
                End = true;
            }
        }
        else
        {
            Interval += Time.deltaTime;
            if (Interval > span)
            {
                StartCount = 5.1f;

                SetMouse();
                Interval = 0.0f;
            }
        }
    }

    void SetMouse()
    {
        Rand = UnityEngine.Random.Range(0, 9);
        if (Rand >= 8)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_9");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 7)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_8");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 6)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_7");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 5)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_6");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 4)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_5");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 3)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_4");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 2)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_3");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 1)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_2");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
        else if (Rand >= 0)
        {
            MouseManager mouseManager;
            GameObject obj = GameObject.Find("Mouse_1");
            mouseManager = obj.GetComponent<MouseManager>();
            mouseManager.get = 2;
        }
    }

    public void ToResult()
    {
        FadeManager.Instance.LoadScene("result", 0.3f);
    }
}
