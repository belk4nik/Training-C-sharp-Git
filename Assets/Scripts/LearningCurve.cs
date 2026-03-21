using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentGold = 67;
    private int currentAge = 30;
    public int addedAge = 1;

    public string text = "Это над тобой смеются )))";
    public string rareItem = "Shaco it just a jester <3";
    public string characterAction = "Attack";


    public bool test = true;
    bool pureOfHeart;
    bool hasSecretIncatation = false;

    public float PI = 3.14f;

    public bool hasDungeonKey = true;







    void Start()
    {

        int characterLevel = 32;

        NewMetod(GenerateCharacter("Spike", characterLevel));

        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Fifa", characterLevel));
        Debug.Log($"A string can have variables like {text} inserted directly!");


        ComputerAge();
        OpenChambler();
        SwitchingAround();

        switch (characterAction)
        {
            case "Heal":
                Debug.Log("heal");
                break;
            case "Attack":
                Debug.Log("Attack");
                break;
            default:
                Debug.Log("test_is_complit");
                break;
        }



        int[] nums1 = new int[] { 1, 2, 3, };

        int[] nums2 = { 1, 2, 3, 4 };

        int test_num = nums2[0];




        List<string> questPartyMembers = new List<string>()
        { "Shaco", "Viego","Corvo"};

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
        questPartyMembers.Add("Craven the Necromancer");


        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Knife", 5},
            {"Potion",6},
            {"Book", 1}
        };

        Debug.LogFormat("Items: {0}", itemInventory.Count);

        itemInventory["Potion"] = 10;

        itemInventory.Add("Throwing Knife", 3);


        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

            if (questPartyMembers[i] == "Shaco")
            {
                Debug.Log("it's joke on YOU!");
            }
        }

        foreach (KeyValuePair<string, int> PM in itemInventory)
        {
            Debug.LogFormat("{0} - key, {1} - Value!", PM.Key, PM.Value);
        }


        ///test of hero

        int gold = 5;

        foreach (KeyValuePair<string, int> PM in itemInventory)
        {
            if (gold >= PM.Value)
            {
                Debug.LogFormat("I can buy this {0}", PM.Key);
            }
            else
            {
                Debug.LogFormat("I can't buy this {0}", PM.Key);
            }
        }

        Character hero = new Character();
        Character hero2 = hero;
        hero2.name = "Sir De Vithoghnton to 2";
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        hero.Reset();
       

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon HuntingBow = new Weapon("Hunting Bow", 135);
        Weapon warBow = HuntingBow;

        warBow.name = "War Bow";
        warBow.damage = 155;

        HuntingBow.PrintWeaponInfo();
        warBow.PrintWeaponInfo();




    }

    /// <summary>
    /// Computer modify age int
    /// </summary>
    void ComputerAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    public void OpenChambler()
    {
        if (pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncatation)
            {
                Debug.Log("You have the spirit, but not the knowledge");
            }
            else
            {
                Debug.Log("the treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when ypu have what it takes");
        }
    }

    public int GenerateCharacter(string nameDemon, int level)
    {
        Debug.LogFormat("Character: {0} - Level - {1} ", nameDemon, level);
        return level + 5;
    }

    public void SwitchingAround()
    {
        int diceRoll = 7;

        switch (diceRoll)
        {
            case 7:
                Debug.Log("Damage 7");
                goto case 15;

            case 15:
                Debug.Log("Damage 15");
                break;
            case 20:
                Debug.Log("Crit DAMAGE!!!");
                break;
            default:
                Debug.Log("Miss");
                break;
        }
    }

    public void NewMetod(int test)
    {
        Debug.Log(test);
    }

    void Update()
    {

    }
}
