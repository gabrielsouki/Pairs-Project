using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayGrid : MonoBehaviour
{
    public List<Transform> positions = new List<Transform>();
    Transform m_transform;
    int m_childCount;

    // Start is called before the first frame update
    void Start()
    {
        GetTransform();
        ChildCount();
        MakeList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MakeList()
    {
        for (int i = 0; i < m_childCount; i++)
        {
            positions.Add(m_transform.GetChild(i));
        }
    }

    void ChildCount()
    {
        m_childCount = m_transform.childCount;
    }

    void GetTransform()
    {
        m_transform = this.gameObject.GetComponent<Transform>();
    }

    //Ahora debo tomar la lista positions y crear la lógica para crear un numero aleatorio
    //entre 0 y la cantidad de elementos que hay en la lista y dependiendo de ese numero
    //asociar el transform de cada elemento tomando este indice con una carte para poder ubicarlas
    //al iniciar el juego.
}
