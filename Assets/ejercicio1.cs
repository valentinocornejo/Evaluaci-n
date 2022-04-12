//Se debe mostrar en consola un mensaje informando la recaudación por entradas de campo y de plateas por separado y luego el total sumado.


//Se debe mostrar qué cantidad del total de la capacidad del predio quedó vacante.Si las entradas vendidas equivalen al total de la capacidad del predio debe mostrarse además el mensaje “Sold Out!”.


//Si la suma de la cantidad de entradas para ambos tipos supera la mitad de la  capacidad del predio debe mostrarse el mensaje “El festival fue un éxito!”. Si no lo supera debe mostrarse “Debemos mejorar la convocatoria.


//Debe mostrarse un mensaje de error descriptivo y no realizar ningún cálculo si la cantidad de entradas vendidas en cualquiera de los tipos es menor a cero o superior a la capacidad del predio para ese tipo.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public int personascampo;
    public int personasplatea;

    // Start is called before the first frame update
    void Start()
    {
        int estadiolleno = 36600;
        int espectadorestotales;
        int campo = 20400;
        int platea = 16200;
        int preciocampo = 1200;
        int precioplatea = 2000;
        int recaudadocampo;
        int recaudadoplatea;
        int totalrecaudado;

        recaudadocampo = personascampo * preciocampo;
        recaudadoplatea = personasplatea * precioplatea;
        totalrecaudado = recaudadocampo + recaudadoplatea;
        Debug.Log("Se recaudo" + recaudadocampo + "por las personas en el campo y "+ recaudadoplatea + " por las personas en la platea. En total se recaudo" + totalrecaudado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
