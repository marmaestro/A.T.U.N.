using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirSonido : MonoBehaviour
{
    public AudioSource ReproductorSonido;

    public void Reproducir()
    {
        ReproductorSonido.Play();
    }
}
