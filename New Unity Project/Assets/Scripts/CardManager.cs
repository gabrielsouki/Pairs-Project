using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public bool isSelected = false;
    [SerializeField] GameplayManager m_gameplayManager;
    [SerializeField] CardClass m_cardClass;
    [SerializeField] CardManager m_cardManager;

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
            m_gameplayManager.selected.Add(m_cardClass);
            m_gameplayManager.Checking();
        }
        else
        {
            isSelected = false;
            m_gameplayManager.selected.Clear();
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
