﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
      if (num1 > num2 && num1 > num3)
        {
            Debug.Log(" El numero mayor es " + num1);

        }
      else if (num3 > num2 && num3 > num1)
        {
            Debug.Log("El numero mayor es " + num3);
        }
      else if (num2 > num1 && num2 > num3)
        {
            Debug.Log(" El numero mayor es " + num2);
        }
      else if ( num2 == num1 && num2 == num3)
        {
            Debug.Log("Los tres numeros son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
