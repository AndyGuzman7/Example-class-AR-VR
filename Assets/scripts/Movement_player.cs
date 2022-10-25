using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_player : MonoBehaviour
{
    public float velocidad = 20;
    public Transform trCamara;

  

    void Update()
    {
        
        //vector normalizado hacia adelante de la camara
        Vector3 f =trCamara.forward;
        f = new Vector3(f.x, 0, f.z);
        f = f.normalized;

        Debug.DrawRay(
            transform.position,
            f,
            Color.blue
        );

        

        Vector3 r = new Vector3(trCamara.right.x, 0, trCamara.right.z).normalized;

        //Vector hacia la derecha de la camara
        Debug.DrawRay(transform.position,  r, Color.red);

        Debug.DrawRay(transform.position, transform.forward *3);

        if(Input.GetKey(KeyCode.RightArrow)){
            transform.forward = r;
            transform.Translate( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.forward = -r;
            transform.Translate( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.forward = f;
            transform.Translate( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.forward = -f;
            transform.Translate( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }


        /*Debug.DrawRay(
            transform.position,
            trCamara.up,
            Color.green
        );

        Debug.DrawRay(
            transform.position,
            trCamara.right,
            Color.red
        );*/
    }
}
