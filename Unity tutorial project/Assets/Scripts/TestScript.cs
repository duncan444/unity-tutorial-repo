using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("you have my sword");
        Debug.Log("and my bow");
        Debug.Log("and my axe");


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.3f, 0, 0);
    }
}
