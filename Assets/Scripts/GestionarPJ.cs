using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GestionarPJ : MonoBehaviour
{
    public GameObject PJ;
    
    
    private bool posibleSuicidio;
    public bool PosibleSuicidio
    {
        set { posibleSuicidio = value; }
    }

    private GameObject objetivoActual;
    public GameObject ObjetivoActual
    {
        set { objetivoActual = value; }
    }

    private bool entradaFallida;

    void Awake()
    {
        entradaFallida = false;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
        
        if (Input.GetKey(KeyCode.F) && posibleSuicidio)
        {
            Suicidarse(objetivoActual);
        }

        if (!entradaFallida)
        {
            entradaFallida = true;
            posibleSuicidio = false;
            objetivoActual = null;
        }
    }
    
    public void Suicidarse(GameObject objetivo)
    {
        if (objetivo is not null)
        {
            string siguienteEscena = objetivo.GetComponent<ConstructorNPJ>().NextScene;
            SceneManager.LoadScene(siguienteEscena);
        }
    }


}
