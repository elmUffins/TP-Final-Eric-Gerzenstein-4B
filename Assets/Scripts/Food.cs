using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject[] comida;
    int counter = 0;
    void Start()
    {
        killEveryone();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            killEveryone();
            comida[counter].SetActive(true);
            if (counter != comida.Length - 1)
            {
                counter++;
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            killEveryone();
            comida[counter].SetActive(true);
            if (counter != 0)
            {
                counter--;
            }

        }

        Debug.Log(counter);
    }

    void killEveryone()
    {
        foreach (var item in comida)
        {
            item.SetActive(false);
        }
    }
}
