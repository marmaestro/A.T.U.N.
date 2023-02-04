using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    // Start is called before the first frame update

    public float fadeDuration = 1.0f;
    public float displayImageDuration = 1.0f;
    //public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    float m_Timer;

    //Configuración del texto de la escena
    public Text TittleText;
    public Text DescriptionText;
    


    private void OnTriggerEnter(Collider other)
    {
       
    }

    void EndLevel()
    {
        m_Timer = Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

        if(m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }

    
}
