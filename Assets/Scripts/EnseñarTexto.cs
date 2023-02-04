using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnseñarTexto : MonoBehaviour
{
    public GameObject CuadroTexto;
    private GameObject textoNombre;
    private GameObject textoSubtitulo;
    
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.GetComponent<ConstructoNPJs>.Name;
        MostrarTexto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//dialogSpace = GameObject.Find("Canvas").transform.GetChild(3).gameObject;
    void MostrarTexto(){
        //pillar los cuadros de texto
        textoNombre = CuadroTexto.transform.GetChild(0).gameObject;
        print(textoNombre.GetComponent<TextMeshProUGUI>().text);
        textoSubtitulo = CuadroTexto.transform.GetChild(1).gameObject;

        //asignarlos a cosas
        textoNombre.GetComponent<TextMeshProUGUI>().text=this.gameObject.GetComponent<ConstructorNPJ>().NpjName;
        textoSubtitulo.GetComponent<TextMeshProUGUI>().text=this.gameObject.GetComponent<ConstructorNPJ>().Subtitle;
    }
}
