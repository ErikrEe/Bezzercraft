using System.Collections;
using System.Collections.Generic;
using UnityEngine;'
using System.Diagnostics;
using System.Linq;

public class Testfortext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //en sådan här skall finnas för varje kategori, det finns 16 kategorier.
        string[] testArray = new string[16]; // creates array = RandomArray(10);  //Fyller en array med en stor mängd slumpmässiga tal
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
        int place = Random.Range(0, testArray.Length);//ska hända när man trycker på knapp
        string quetionInText = testArray[place]; //questionInText ska vara texten i eriks script som skrivs ut

        //nu bör den positionen försvinna men hinner inte koda det just nu


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
