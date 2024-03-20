using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.XR;

public class CharacterControl : MonoBehaviour
{


    public static Villager SelectedVillager { get; private set; }

    public GameObject guiTest;

    //public static TextMeshProUGUI selected;
    public  TextMeshProUGUI selected;
    private void Start()
    {
        guiTest = GameObject.Find("guiTest");
        selected = guiTest.GetComponent<TextMeshProUGUI>();
    }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        
        UpdateGUI(villager);
    }

    private void Update()
    {
        if (SelectedVillager != null)
        {
            selected.SetText(SelectedVillager.CanOpen().ToString());
        }
    }

    public static void UpdateGUI(Villager villager)
    {
       // selected.SetText(villager.CanOpen().ToString());
    }
    
}
