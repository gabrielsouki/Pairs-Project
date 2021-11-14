using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClass : MonoBehaviour
{
    [SerializeField] string color;
    [SerializeField] bool done;

    public void Init(string m_color, bool m_done)
    {
        color = m_color;
        done = m_done;
    }
}
