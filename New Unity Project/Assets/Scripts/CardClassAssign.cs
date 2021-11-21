using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClassAssign : MonoBehaviour
{
    [SerializeField] string m_color;
    [SerializeField] bool m_done;
    [SerializeField] CardClass card;

    public void Init()
    {
        //card.Init(m_color, m_done);
    }

    private void Start()
    {
        Init();
    }
}
