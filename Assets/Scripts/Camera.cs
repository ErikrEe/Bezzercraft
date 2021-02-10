using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{

    public Button Combat;
    public Button Mining;
    public Button Building;
    public Button Farming;
    public Button Redstone;
    public Button Monsters;
    public Button Enchanting;
    public Button Nether;
    public Button Fishing;
    public Button End;
    public Button Crafting;
    public Button Structures;
    public Button Biomes;
    public Button Animals;
    public Button Meta;
    public Button Potions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Disable()
    {
        Combat.gameObject.SetActive(false);
        Mining.gameObject.SetActive(false);
        Building.gameObject.SetActive(false);
        Farming.gameObject.SetActive(false);
        Redstone.gameObject.SetActive(false);
        Monsters.gameObject.SetActive(false);
        Enchanting.gameObject.SetActive(false);
        Nether.gameObject.SetActive(false);
        Fishing.gameObject.SetActive(false);
        End.gameObject.SetActive(false);
        Crafting.gameObject.SetActive(false);
        Structures.gameObject.SetActive(false);
        Biomes.gameObject.SetActive(false);
        Animals.gameObject.SetActive(false);
        Meta.gameObject.SetActive(false);
        Potions.gameObject.SetActive(false);
    }

    public void Enable()
    {
        Combat.gameObject.SetActive(true);
        Mining.gameObject.SetActive(true);
        Building.gameObject.SetActive(true);
        Farming.gameObject.SetActive(true);
        Redstone.gameObject.SetActive(true);
        Monsters.gameObject.SetActive(true);
        Enchanting.gameObject.SetActive(true);
        Nether.gameObject.SetActive(true);
        Fishing.gameObject.SetActive(true);
        End.gameObject.SetActive(true);
        Crafting.gameObject.SetActive(true);
        Structures.gameObject.SetActive(true);
        Biomes.gameObject.SetActive(true);
        Animals.gameObject.SetActive(true);
        Meta.gameObject.SetActive(true);
        Potions.gameObject.SetActive(true);
    }

}
