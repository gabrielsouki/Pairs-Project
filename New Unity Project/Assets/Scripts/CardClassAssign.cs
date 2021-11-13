using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClassAssign : MonoBehaviour
{
    public string m_color;
    public bool done;

    private void Start()
    {
        CardClass.card card = new CardClass.card(m_color, done);
    }
}
