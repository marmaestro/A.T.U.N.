using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorNPJ : MonoBehaviour
{
    [SerializeField]
    private string npjName;
    public string NpjName{
        get{ return npjName;}
        set{ npjName =value;}
    }
[SerializeField]
    private string subtitle;
    public string Subtitle{
        get{return subtitle;}
        set{ subtitle=value;}
    }

    public string NextPj;
    public string NextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
