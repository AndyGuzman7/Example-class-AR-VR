using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrador : MonoBehaviour
{
    public GameObject pinzas;
    public MoveR padre;
    private  bool active = false;

    private void Update() {
        Debug.Log(active);
    }
    private void OnTriggerEnter(Collider other) {
         if(padre.usePinzas)
        {
            active = true;
        }
        else
        {
            active = false;
        }
    }

  

    void OnTriggerStay(Collider otro)
    {
        /*if(padre.usePinzas)
        {
            otro.transform.SetParent(pinzas.transform);
            active = true;
        }
        else{
            
                otro.transform.SetParent(null);
                Rigidbody pelota = otro.transform.GetComponent<Rigidbody>();
                pelota.isKinematic = false;
            
            
        }*/

       
        //active = !active;
    }

    
}
