using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{

    private Renderer RendererProp;



    // Start is called before the first frame update
    void Start()
    {
        RendererProp = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        RendererProp.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        RendererProp.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
