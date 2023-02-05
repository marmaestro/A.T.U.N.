using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NombreZona : MonoBehaviour
{
    public CanvasGroup EspacioTexto;
    private const float TIEMPO_ESPERA = 1.0f;
    private const float TIEMPO_EN_PANTALLA = 5.0f;
    
    void Start()
    {
        StartCoroutine(Esperar());
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(TIEMPO_ESPERA);
        EspacioTexto.alpha = 1;
        yield return new WaitForSeconds(TIEMPO_EN_PANTALLA);
        EspacioTexto.alpha = 0;
    }

}
