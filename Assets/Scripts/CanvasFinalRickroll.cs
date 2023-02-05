using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasFinalRickroll : MonoBehaviour
{
    private float m_Timer;
    private float m_TimerVideo;
    public const float DURACION_VIDEO = 15.0f;
    private const float DURACION_FADE = 5.0f;
    public Canvas Canvas;
    public CanvasGroup CanvasGroup;

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
        if(m_TimerVideo < DURACION_VIDEO)
        {
            EsperarVideo();
        }
        else
        {
            MostrarFinal();
        }
    }

    public void EsperarVideo()
    {
        m_TimerVideo += Time.deltaTime;
    }

    public void MostrarFinal()
    {
        m_Timer += Time.deltaTime;
        CanvasGroup.alpha = m_Timer / DURACION_FADE;

        if(m_Timer > DURACION_FADE)
        {
            Canvas.transform.GetChild(5).GetComponent<PulsarFSalir>().enabled = true;
        }
    }
}
