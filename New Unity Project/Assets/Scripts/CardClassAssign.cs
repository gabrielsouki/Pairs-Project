using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CardAssignment
{
    [SerializeField] string m_color;
    [SerializeField] bool m_done;
    [SerializeField] CardClass card;

    public void Init()
    {
        card.Init(m_color, m_done);
    }
}

public class CardClassAssign : MonoBehaviour
{
    [SerializeField] List<CardAssignment> cards = new List<CardAssignment>();

    private void Start()
    {
        /*foreach(var c in cards)
        {
            c.Init();
        }*/

        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].Init();
        }
    }
}
