using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidadeAnimalitos : MonoBehaviour
{
    int comidaGatos = 300;
    int comidaPP = 400;
    int comidaPG = 700;
    public string IDanimal;
    int cantidadComida;
    public int cantidadDias;
    float precioAlimento = 0.8f;
    float precioTotal;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDias < 3)
        {
            Debug.Log("ERROR; la cantidad de días debe ser mayor a 3");
            return;
        }
        if (IDanimal == "G")
        {
            cantidadComida = comidaGatos * cantidadDias;
            Debug.Log("Para ese período se necesitan  " + cantidadComida + "g gramos de alimento");
            Debug.Log("Costo de los alimentos = $" + cantidadComida * precioTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
