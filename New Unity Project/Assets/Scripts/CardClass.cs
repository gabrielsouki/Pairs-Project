using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClass : MonoBehaviour
{
    public class card
    {
        public string color;
        public bool done;

        public card(string m_color, bool m_done)
        {
            color = m_color;
            done = m_done;
        }
    }

    // Find the way to personalize each card class parameter

    //public card gameCard = new card("Red", false);
}
