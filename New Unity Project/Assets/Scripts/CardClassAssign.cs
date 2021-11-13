using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClassAssign : MonoBehaviour
{
    public string m_color;
    public bool done;

    private void Start()
    {
        public CardClass.card card = new CardClass.card("Red", false);
    }
}
