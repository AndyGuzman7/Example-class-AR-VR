using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour
{
    public Transform objetivo;
    public float horizontal;
    public float velocidad = 20;


    void Update()
    {
        Vector3 pos = transform.position;

        pos = Vector3.Lerp(pos, objetivo.position, 0.5f);

        transform.position = pos;

        //transform.position = objetivo.position;

        //horizontal = Input.GetAxis("Horizontal");
        //transform.Rotate(0,horizontal*velocidad,0);
    }
}
