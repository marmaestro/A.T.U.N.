using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PulsarFInicio : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("HORA_DEL_BOCADILLO");
        }
    }
}
