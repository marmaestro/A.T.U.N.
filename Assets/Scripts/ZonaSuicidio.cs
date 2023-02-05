using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaSuicidio : MonoBehaviour
{
    public GameObject PJ;
    public GameObject PNJAsociado;

    private void Awake()
    {
        transform.position = PNJAsociado.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ENTRA");
        PJ.GetComponent<GestionarPJ>().ObjetivoActual = PNJAsociado;
        PJ.GetComponent<GestionarPJ>().PosibleSuicidio = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("SALE");
        PJ.GetComponent<GestionarPJ>().ObjetivoActual = null;
        PJ.GetComponent<GestionarPJ>().PosibleSuicidio = true;
    }
}
