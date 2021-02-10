using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Text : MonoBehaviour
{

    public Text questions;


    // Start is called before the first frame update
    void Start()
    {
        //questions = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    /*
    public void EnableText()
    {
        Debug.Log("texttttttt");
        questions.gameObject.SetActive(true);
    }

    public void DisableText()
    {
        questions.gameObject.SetActive(false);
    }
    */
    
    public void EnableText()
    {
        questions.gameObject.SetActive(true);
        questions.enabled = true;
        Debug.Log("texttttttt");
    }

    public void DisableText()
    {
        questions.enabled = false;
    }
    
}
