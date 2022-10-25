using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorAgarrables : MonoBehaviour
{

    private Transform objeto;
    public Transform Objeto
    {
        get { return objeto; }
        set { objeto = value; }
    }
    
    private bool estaAgarrado;
    public bool EstaAgarrado
    {
        get { return estaAgarrado; }
        set { estaAgarrado = value; }
    }
    
    private bool detectado;
    private Pinza pinza;
    public Pinza Pinza
    {
        get { return pinza; }
        set { pinza = value; }
    }
    
    public bool Detectado
    {
        get { return detectado; }
        set { detectado = value; }
    }

    private void Start() {
        Detectado = false;
        pinza = GetComponentInParent<Pinza>();
    }

    private void Update() {
        if(!estaAgarrado)
        {
            if(detectado && pinza.agarreOk)
            {
                estaAgarrado = true;
                objeto.SetParent(transform);
                CambiarColorComponente(objeto, Color.red);

            }
        }else
        {
            if(!pinza.agarreOk)
            {
                estaAgarrado = false;
                objeto.SetParent(null);
                CambiarColorComponente(objeto, Color.black);
            }
        }
    }
    

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "agarrable")
        {
            detectado = true;
            objeto = other.transform;
            

        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "agarrable")
        {
            detectado = false;
            objeto = null;

        }
    }

    public void CambiarColorComponente(Transform transform, Color color)
    {
        MeshRenderer mesh = transform.GetComponent<MeshRenderer>();
        mesh.material.color = color;
    }
}
