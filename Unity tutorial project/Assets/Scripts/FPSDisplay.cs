using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSDisplay : MonoBehaviour
{

    int frameCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(frameCount);
        frameCount = frameCount + 1;
    }
}
