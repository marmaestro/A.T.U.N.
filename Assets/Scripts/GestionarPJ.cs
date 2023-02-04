using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionarPJ : MonoBehaviour
{
    public GameObject PJ;
    public GameObject[] Objetivos;

    private float threshold;

    void Start()
    {
        threshold = 2f;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;     
        
        if (Input.GetKey(KeyCode.F))
        {
            Suicidarse();
        }
    }
    
    public void Suicidarse()
    {
        GameObject objetivo = null;
        float distMenor = float.PositiveInfinity;

        foreach (GameObject objt in Objetivos)
        {
            float dist = Vector3.Distance(PJ.transform.position, objt.transform.position);
            if (dist <= threshold)
            {
                if (objetivo == null || dist < distMenor)
                {
                    objetivo = objt;
                    distMenor = dist;
                }
            }
        }

        if (objetivo is not null)
        {
            string siguienteEscena = objetivo.GetComponent<ConstructorNPJ>().NextScene;
            SceneManager.LoadScene(siguienteEscena);
        }
        
    }


}
