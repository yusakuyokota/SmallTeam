using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject[] MouseBox = new GameObject[2];
    private float Interval = 0.0f;
    private float span = 2f;

    private int Rand;

    int temp = 0;

    // Start is called before the first frame update
    void Start()
    {
        MouseBox[0].gameObject.SetActive(false);
        MouseBox[1].gameObject.SetActive(false);
        //MouseBox[2].gameObject.SetActive(false);
        //MouseBox[3].gameObject.SetActive(false);
        //MouseBox[4].gameObject.SetActive(false);
        //MouseBox[5].gameObject.SetActive(false);
        //MouseBox[6].gameObject.SetActive(false);
        //MouseBox[7].gameObject.SetActive(false);
        //MouseBox[8].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Interval += Time.deltaTime;
        if (Interval > span)
        {
            SetMouse();
            Interval = 0.0f;
        }
    }

    void SetMouse()
    {
        //Rand = UnityEngine.Random.Range(0, 2);
        //if (Rand >= 8)
        //{
        //    MouseBox[8].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_9");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        //else if (Rand >= 7)
        //{
        //    MouseBox[7].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_8");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        //else if (Rand >= 6)
        //{
        //    MouseBox[6].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_7");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        //else if (Rand >= 5)
        //{
        //    MouseBox[5].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_6");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        //else if (Rand >= 4)
        //{
        //    MouseBox[4].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_5");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        //else if (Rand >= 3)
        //{
        //    MouseBox[3].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_4");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        //else if (Rand >= 2)
        //{
        //    MouseBox[2].gameObject.SetActive(true);
        //    MouseManager mouseManager;
        //    GameObject obj = GameObject.Find("Mouse_3");
        //    mouseManager = obj.GetComponent<MouseManager>();
        //    mouseManager.get = 2;
        //}
        if (Rand >= 1)
        {
            MouseBox[1].gameObject.SetActive(true);
            MouseTest1 mouse1;
            GameObject obj1 = GameObject.Find("MouseImage");
            mouse1 = obj1.GetComponent<MouseTest1>();
            mouse1.get = 2;
        }
        else if (Rand >= 0)
        {
            MouseBox[0].gameObject.SetActive(true);
            MouseTest2 mouse2;
            GameObject obj2 = GameObject.Find("MouseImage2");
            mouse2 = obj2.GetComponent<MouseTest2>();
            mouse2.get = 2;
        }
    }

    //void SetMouse()
    //{
    //    Rand = UnityEngine.Random.Range(0, 9);
    //    if (Rand >= 8)
    //    {
    //        MouseBox[8].gameObject.SetActive(true);
    //        Mouse_9 mouse_9;
    //        GameObject obj = GameObject.Find("Mouse_9");
    //        mouse_9 = obj.GetComponent<Mouse_9>();
    //        mouse_9.get = 2;
    //    }
    //    else if (Rand >= 7)
    //    {
    //        MouseBox[7].gameObject.SetActive(true);
    //        Mouse_8 mouse_8;
    //        GameObject obj = GameObject.Find("Mouse_8");
    //        mouse_8 = obj.GetComponent<Mouse_8>();
    //        mouse_8.get = 2;
    //    }
    //    else if (Rand >= 6)
    //    {
    //        MouseBox[6].gameObject.SetActive(true);
    //        Mouse_7 mouse_7;
    //        GameObject obj = GameObject.Find("Mouse_7");
    //        mouse_7 = obj.GetComponent<Mouse_7>();
    //        mouse_7.get = 2;
    //    }
    //    else if (Rand >= 5)
    //    {
    //        MouseBox[5].gameObject.SetActive(true);
    //        Mouse_6 mouse_6;
    //        GameObject obj = GameObject.Find("Mouse_6");
    //        mouse_6 = obj.GetComponent<Mouse_6>();
    //        mouse_6.get = 2;
    //    }
    //    else if (Rand >= 4)
    //    {
    //        MouseBox[4].gameObject.SetActive(true);
    //        Mouse_5 mouse_5;
    //        GameObject obj = GameObject.Find("Mouse_5");
    //        mouse_5 = obj.GetComponent<Mouse_5>();
    //        mouse_5.get = 2;
    //    }
    //    else if (Rand >= 3)
    //    {
    //        MouseBox[3].gameObject.SetActive(true);
    //        Mouse_4 mouse_4;
    //        GameObject obj = GameObject.Find("Mouse_4");
    //        mouse_4 = obj.GetComponent<Mouse_4>();
    //        mouse_4.get = 2;
    //    }
    //    else if (Rand >= 2)
    //    {
    //        MouseBox[2].gameObject.SetActive(true);
    //        Mouse_3 mouse_3;
    //        GameObject obj = GameObject.Find("Mouse_3");
    //        mouse_3 = obj.GetComponent<Mouse_3>();
    //        mouse_3.get = 2;
    //    }
    //    else if (Rand >= 1)
    //    {
    //        MouseBox[1].gameObject.SetActive(true);
    //        Mouse_2 mouse_2;
    //        GameObject obj = GameObject.Find("Mouse_2");
    //        mouse_2 = obj.GetComponent<Mouse_2>();
    //        mouse_2.get = 2;
    //    }
    //    else if (Rand >= 0)
    //    {
    //        MouseBox[0].gameObject.SetActive(true);
    //        Mouse_1 mouse_1;
    //        GameObject obj = GameObject.Find("Mouse_1");
    //        mouse_1 = obj.GetComponent<Mouse_1>();
    //        mouse_1.get = 2;
    //    }
    //}
}
