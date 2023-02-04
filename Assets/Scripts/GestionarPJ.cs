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
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        if (Input.GetKeyDown("A") || Input.GetKeyDown("LEFT"))
        {
            rigidbody.AddForce(Vector3.left);
        }
        if (Input.GetKeyDown("D") || Input.GetKeyDown("RIGHT"))
        {
            rigidbody.AddForce(Vector3.right);
        }
        if (Input.GetKeyDown("W") || Input.GetKeyDown("UP"))
        {
            rigidbody.AddForce(Vector3.up);
        }
        if (Input.GetKeyDown("S") || Input.GetKeyDown("DOWN"))
        {
            rigidbody.AddForce(Vector3.down);
        }
        
        
        if (Input.GetKeyDown("F"))
        {
            Suicidarse();
        }
    }
    
    public void Suicidarse()
    {
        GameObject objetivo = null;
        float distMenor;

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
