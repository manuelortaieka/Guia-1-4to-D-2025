using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversiondeMoneda : MonoBehaviour
{

    public float montoAConvertir;
    public string codigoMoneda;

    float montoConvertido;
    float montoMinimo = 1000;
    float cotizacionMonedaElegida;
    float cotizacionEuro = 1621.3f;
    float cotizacionDolar = 1297.21f;
    float cotizacionReal = 183.0f;

    // Start is called before the first frame update
    void Start()
    {

        if (montoAConvertir < montoMinimo) 
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
            montoConvertido = montoAConvertir / cotizacionMonedaElegida;
            Debug.Log("el monto convertido seria " + montoConvertido);
        }
        else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
            montoConvertido = montoAConvertir / cotizacionMonedaElegida;
            Debug.Log("el monto convertido seria " + montoConvertido);
        }
        else if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = 1297.21f;
            montoConvertido = montoAConvertir / cotizacionMonedaElegida;
            Debug.Log("el monto convertido seria " + montoConvertido);
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
