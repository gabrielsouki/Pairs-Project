using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{

    public List<CardClass> selected = new List<CardClass>();
    public List<Transform> cardsPosition = new List<Transform>();
    [SerializeField] GameObject cards;
    int cardsCount;
    [SerializeField] GameplayGrid m_gameplayGrid;

    private void Start()
    {
        Debug.Log(m_gameplayGrid.positions.Count);
        GetCardsCount();
        ListCards();
        AssignPosition();
        
    }

    void GetCardsCount()
    {
        cardsCount = cards.transform.childCount;
    }

    void ListCards()
    {
        for (int i = 0; i < cardsCount; i++)
        {
            cardsPosition.Add(cards.transform.GetChild(i));
        }
    }

    void AssignPosition()
    {
        foreach(Transform position in cardsPosition)
        {
            int randomNumber = RandomNumber();
            position.position = m_gameplayGrid.positions[randomNumber].position;
            m_gameplayGrid.positions.RemoveAt(randomNumber);
        }
    }

    int RandomNumber()
    {
        return UnityEngine.Random.Range(0, m_gameplayGrid.positions.Count);
    }

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
