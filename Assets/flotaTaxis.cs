using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flotaTaxis : MonoBehaviour
{
    public int dias; 
    public int cantidadDeUnidades;
    public int diasDeLluvia;
    // Start is called before the first frame update
    void Start()
    {
        if (dias > 5)
        {
            int kmsTotPorDia = (dias - diasDeLluvia) * (cantidadDeUnidades * 90);
            int kmsTotPorDiaLluvia = (diasDeLluvia - dias * -1 ) * (cantidadDeUnidades * 30) + kmsTotPorDia;
            int costoTotCombustible = ((kmsTotPorDia + kmsTotPorDiaLluvia)/ 15) * 130;
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + dias + 
                " días implicará un gasto de " + costoTotCombustible + " pesos en concepto de combustible.");
             
        
            
       

        }
        else if (dias < 5 || diasDeLluvia > dias || diasDeLluvia < 0)
        {
            Debug.Log("La cantidad de dias ingresados no es valida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
