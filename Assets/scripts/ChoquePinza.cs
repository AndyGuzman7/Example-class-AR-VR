using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoquePinza : MonoBehaviour
{
    void OnTriggerStay(Collider otro)
    {
        otro.transform.GetComponent<Rigidbody>().isKinematic = true;
    }
}
