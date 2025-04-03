using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar
//    un  programa que informe si un estacionamiento se encuentra o no 
//    abierto según la hora  ingresada por el usuario.
//Nosotros sabemos que el estacionamiento se encuentra abierto 
//        entre las 10 y las 18hs.
//Al iniciar el programa, se tomará como hora actual el 
//        valor de una variable expuesta en el Inspector, y deberemos setear 
//        una variable booleana llamada estaAbierto en true o false, 
//        según corresponda, e informar por consola mediante la misma si 
//        el estacionamiento se encuentra abierto o no.
//        Obs: En el caso de que el valor de la variable corresponda a 
//        una hora menor a 0 o mayor a 24, mostrar el  mensaje: 
//        “Ha ingresado una hora incorrecta” 


public class Estacionamiento : MonoBehaviour
{
    public int horaActual;
    bool estaAbierto;

    // Start is called before the first frame update
    void Start()
    {
        if(horaActual < 0 || horaActual > 24)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
            return;
        }
        else if(horaActual >= 10 && horaActual < 18)
        {
            estaAbierto = true;
        }
        else
        {
            estaAbierto = false;
        }
        Debug.Log("El estacionamiento está abierto: " + estaAbierto);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
