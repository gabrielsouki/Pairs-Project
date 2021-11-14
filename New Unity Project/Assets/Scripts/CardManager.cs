using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public bool isSelected = false;
    public GameplayManager m_gameplayManager;
    public CardClassAssign m_cardClassAssign;
    public CardManager thisCardManager;

    //Detectar clic
    private void OnMouseDown()
    {
        Select();
    }

    public void Select()
    {
        if(isSelected == false)
        {
            isSelected = true;
            //m_gameplayManager.selected.Add(m_cardClassAssign.newCard.color, thisCardManager);
        }
        else
        {
            isSelected = false;
        }
    }

    private void Update()
    {
        Check();
    }

    public void Check()
    {
        if (isSelected)
        {
            Destroy(gameObject);
        }
    }
}
