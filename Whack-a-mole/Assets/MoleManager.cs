using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    public GameObject Mole = new GameObject();
    private float Interval = 0.0f;
    bool Check = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Mole.gameObject.SetActive(false);
            Check = false;
            Interval = 0.0f;
        }

        if (!Check) Interval += Time.deltaTime;

        if (Interval >= 3.0f)
        {
            Mole.gameObject.SetActive(true);
            Check = true;
        }
        
    }
}
