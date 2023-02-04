using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasFinal : MonoBehaviour
{
    public string NombreEscena;
    public string TipoFinal;

    private float m_Timer;
    private const float duracionFade = 5.0f;
    //private const float duracionImagen = 1.0f;

    public Canvas Canvas;
    public GameObject SubtituloEscena;
    public GameObject SubtituloFinal;
    public CanvasGroup CanvasGroup;
    public Color Color;

    /*public void Awake()
    {
        SubtituloEscena.GetComponent<TextMeshPro>().text += NombreEscena;
        //Canvas.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text += NombreEscena;
        SubtituloFinal.GetComponent<TextMeshPro>().text += TipoFinal;
        //Canvas.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text += NombreEscena;
        SubtituloFinal.GetComponent<TextMeshPro>().color = Color;
        //Canvas.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().color = Color;
    }*/

    void Update()
    {
        MostrarFinal();
    }

    public void MostrarFinal()
    {
        m_Timer += Time.deltaTime;
        CanvasGroup.alpha = m_Timer / duracionFade;

        if(m_Timer > duracionFade)
        {
            Application.Quit();
        }
    }

    public void VolverAlInicio()
    {
        SceneManager.LoadScene("INICIO");
    }

    public void A()
    {
        Debug.Log("A");
    }
}
