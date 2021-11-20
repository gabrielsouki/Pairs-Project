using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public List<CardClass> selected = new List<CardClass>();

    
    public void Checking()
    {
        
        if (selected.Count == 2)
        {
            if (selected[0].color == selected[1].color)
            {
                CardManager Card1 = selected[0].gameObject.GetComponent<CardManager>();
                Card1.Destroy();
                CardManager Card2 = selected[1].gameObject.GetComponent<CardManager>();
                Card2.Destroy();
                selected.Clear();
            }
            else
            {
                CardManager Card1 = selected[0].gameObject.GetComponent<CardManager>();
                Card1.isSelected = false;
                CardManager Card2 = selected[1].gameObject.GetComponent<CardManager>();
                Card2.isSelected = false;
                selected.Clear();
            }
        }
    }
}
