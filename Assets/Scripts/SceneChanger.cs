using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public string SceneName;
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
