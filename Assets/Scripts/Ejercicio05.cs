﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        int resultado;
        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por cero ");
        }
        else
        {
            resultado = num1 / num2;
            Debug.Log(num1 + " / " + num2 + " = " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
