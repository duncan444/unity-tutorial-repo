using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestScript : MonoBehaviour

{
    [SerializeField]
    string combinedString;
    [SerializeField]
    string editorString = "test";
    [SerializeField]
    float targetScale = 1.0f;
    [SerializeField]
    SpriteRenderer playerSprite = null;
    [SerializeField]
    Color spriteColor = Color.white;
    // Start is called before the first frame update

    Vector3 changingScale = new Vector3(1.0f, 1.0f, 1.0f);

  

    void Start()
    {   
        /*
        Debug.Log("you have my sword");
        Debug.Log("and my bow");
        Debug.Log("and my axe");
        */

        string firstString;
        string secondString;
 


        firstString = "you shall not ";
        secondString = "pass";
        combinedString = firstString + " " + secondString;


        Debug.Log(combinedString);
        Debug.Log(editorString);

        playerSprite.color = spriteColor;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.3f, 0, 0);
        Debug.Log(combinedString);

        Debug.Log(targetScale);
        targetScale = targetScale + 1.0f;

        changingScale.x = targetScale;
        changingScale.y = targetScale;
        changingScale.z = targetScale; 

        transform.localScale = changingScale;
    }
}
