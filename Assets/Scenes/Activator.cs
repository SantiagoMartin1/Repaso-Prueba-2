using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour
{
    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        abc();
    }

    void abc()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (myCube.activeInHierarchy)
            {
                myCube.SetActive(false);
            }
            else
            {
                myCube.SetActive(true);
            }
        }
        myCube.SetActive(!myCube.activeInHierarchy);
    }
}
