using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public bool isSelected = false;
    public CardManager par;

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
        if (isSelected && par.isSelected)
        {
            Destroy(gameObject);
        }
    }
}
