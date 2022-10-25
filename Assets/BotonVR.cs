using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BotonVR : MonoBehaviour
{

     [SerializeField]
    MoveR robot;
    [SerializeField]
    Transform cuboClick;

    Vector3 posPresionado, posOriginal;


    public UnityEvent cuandoPresion;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Presionar()
    {
        posPresionado = posOriginal - Vector3.up * 0.2f;
        cuboClick.localPosition = posPresionado;
        CambiarColorComponente(cuboClick, Color.green);
        //robot.HorizontalArticulacion(true);
        cuandoPresion.Invoke();
    }

    public void Soltar()
    {
        posPresionado = posOriginal + Vector3.up * 0.2f;
        cuboClick.localPosition = posPresionado;
        CambiarColorComponente(cuboClick, Color.red);
    }

   


    public void CambiarColorComponente(Transform transform, Color color)
    {
        MeshRenderer mesh = transform.GetComponent<MeshRenderer>();
        mesh.material.color = color;
    }





}

/*

GameObejct 
Transform





*/