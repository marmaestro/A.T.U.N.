using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnseñarTexto : MonoBehaviour
{
    private GameObject texto;
    public string NombrePersonaje;
    
    void Awake()
    {
        texto = this.gameObject.transform.GetChild(0).gameObject;
        texto.GetComponent<TextMeshPro>().text = NombrePersonaje;
        texto.transform.position = new Vector3(texto.transform.position.x, this.transform.position.y + this.GetComponent<SpriteRenderer>().sprite.bounds.max.y + 0.2f, 0);

    }
}

// Con todo el cariño, Alan, pero quito tu código porque peta un cristo.
/*public class EnseñarTexto : MonoBehaviour
{
    public GameObject CuadroTexto;
    public GameObject PJ;

    private GameObject textoNombre;
    private GameObject textoSubtitulo;
    private float distanciaAPJ;
    
    // Start is called before the first frame update
    void Start()
    {
        distanciaAPJ = 2.5f;
        //this.gameObject.GetComponent<ConstructoNPJs>.Name;
        //MostrarTexto();
    }

    // Update is called once per frame
    void Update()
    {
        if (DistanciaAPjAdecuada()) MostrarTexto();
    }
//dialogSpace = GameObject.Find("Canvas").transform.GetChild(3).gameObject;
    void MostrarTexto(){
        //pillar los cuadros de texto
        textoNombre = CuadroTexto.transform.GetChild(0).gameObject;
        print(textoNombre.GetComponent<TextMeshProUGUI>().text);
        textoSubtitulo = CuadroTexto.transform.GetChild(1).gameObject;

        //asignarlos a cosas
        textoNombre.GetComponent<TextMeshProUGUI>().text = this.gameObject.GetComponent<ConstructorNPJ>().NpjName;
        textoSubtitulo.GetComponent<TextMeshProUGUI>().text = this.gameObject.GetComponent<ConstructorNPJ>().Subtitle;
    }
    bool DistanciaAPjAdecuada(){
        //print(PJ.GetComponent<Transform>().position +", "+ transform.position+", "+distanciaAPJ+": "+(Vector3.Distance(PJ.GetComponent<Transform>().position, transform.position)<distanciaAPJ));
        return(Vector3.Distance(PJ.GetComponent<Transform>().position, transform.position) < distanciaAPJ);
    }
}*/
