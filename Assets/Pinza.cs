using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinza : MonoBehaviour
{
    [SerializeField]
    [Range(0, 1)]


    private float agarre;
    public float Agarre
    {
        get { return agarre; }
        set { agarre = value; }
    }
    
    
    public Transform _indice;
    public Transform _pulgar;


    public bool agarreOk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float indiceValue = Mathf.Lerp(-25, 2, agarre);
        _indice.localRotation = Quaternion.Euler(new Vector3(0, 0,indiceValue));
        float pulgarValue = Mathf.Lerp(8, -14, agarre);
        _pulgar.localRotation = Quaternion.Euler(new Vector3(0, 0, pulgarValue));

        if(agarre >= 0.8f)
        {
            agarreOk = true;
        }
        else{
            agarreOk = false;
        }
    }

}
