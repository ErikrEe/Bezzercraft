using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text questions;
    public string questionInText;
    public int place;
    //en sådan här skall finnas för varje kategori, det finns 16 kategorier.
    string[] testArray = new string[16]; // creates array = RandomArray(10);  //Fyller en array med en stor mängd slumpmässiga tal
    string[] selectedArray, combatArray, endArray, farmingArray, biomesArray, enchantingArray, miningArray, potionsArray, craftingArray, redstoneArray, animalsArray, netherArray, buildingArray, structuresArray, monstersArray, metaArray, fishingArray;
    // Start is called before the first frame update
    void Start()
    {

        questions = GetComponent<Text>();
        #region asigning strings to the testArray
        testArray[0] = "test 0"; //på plats 0 är fråga "hej"
        testArray[1] = "test 1";
        testArray[2] = "test 2";
        testArray[3] = "test 3";
        testArray[4] = "test 4";
        testArray[5] = "test 5";
        testArray[6] = "test 6";
        testArray[7] = "test 7";
        testArray[8] = "test 8";
        testArray[9] = "test 9";
        testArray[10] = "test 10";
        testArray[11] = "test 11";
        testArray[12] = "test 12";
        testArray[13] = "test 13";
        testArray[14] = "test 14";
        testArray[15] = "test 15";
        #endregion

        #region combat Array Questions
        combatArray[0] = "";
        combatArray[1] = "";
        combatArray[2] = "";
        combatArray[3] = "";
        combatArray[4] = "";
        combatArray[5] = "";
        combatArray[6] = "";
        combatArray[7] = "";
        combatArray[8] = "";
        combatArray[9] = "";
        combatArray[10] = "";
        combatArray[11] = "";
        combatArray[12] = "";
        combatArray[13] = "";
        combatArray[14] = "";
        combatArray[15] = "";
        #endregion 

    }

    // Update is called once per frame
    void Update()
    {



    }

    #region assigning what array should be used for what button
    public void CategoryTest() //en sån här funktion bör sitta på varje knapp, unik för varje knapp för att välja vilket kategori av frågor
    {
        selectedArray = testArray;
    }
    public void CategoryCombat() 
    {
        selectedArray = combatArray;
    }
    #endregion region

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
    public void DefineText()
    {
        place = Random.Range(0, 16);// selectedArray.Length);//ska hända när man trycker på knapp
        questionInText = selectedArray[place]; //questionInText ska vara texten i eriks script som skrivs ut
        questions.text = questionInText;
        //nu bör den positionen försvinna men hinner inte koda det just nu

    }

    public void EnableText()
    {
        DefineText();
        questions.gameObject.SetActive(true);
        questions.enabled = true;
        Debug.Log("text has been enabled");
    }

    public void DisableText()
    {
        questions.enabled = false;
    }
    
}
