using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    private float m_Timer;
    private const float duracion = 5.0f;

    void Update()
    {
        Contar();
    }

    public void Contar()
    {
        m_Timer += Time.deltaTime;

        if(m_Timer > duracion)
        {
            SceneManager.LoadScene("HORA_DEL_BOCADILLO");
        }
    }
}
