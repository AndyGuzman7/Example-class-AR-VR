using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveR : MonoBehaviour
{
    [Header("Parametros Control")]
    [SerializeField]
    float velocidadArticulacion = 50;

    [Header("Paramentros")]

    const float ANGULO_MAXIMOH = 360;
    const float ANGULO_MINIMOH = -360;
    const float ANGULO_MAXIMOV = 135;
    const float ANGULO_MINIMOV = -135;
    [Range(-100, 300)]
    public float upDown = 90;

     [Range(-100, 300)]
    public float leftRight = 90;
    public GameObject articulacion;
    public bool useSlider = false;
    public float velocidad = 20;


    public GameObject pinza1;
    public GameObject pinza2;

    public bool usePinzas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow )){
          
            articulacion.transform.Rotate(new Vector3(0,1,0));// = Quaternion.Euler( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
           articulacion.transform.Rotate(new Vector3(0,-1,0));
            //transform.rotation = Quaternion.Euler( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Rotate(new Vector3(0,1,0));
           
             //transform.rotation = Quaternion.Euler( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
             transform.Rotate(new Vector3(0,-1,0));
            // transform.rotation = Quaternion.Euler( new Vector3(0,0,1) * Time.deltaTime * velocidad);
        }

        if(useSlider)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,leftRight,0));
            articulacion.transform.localRotation = Quaternion.Euler(new Vector3(upDown,90,90));
        }

        if(usePinzas)
        {
            pinza1.transform.localPosition = (new Vector3(2,0.2f,0));
            pinza2.transform.localPosition =(new Vector3(2,-0.2f,0));
        }
        else{
            pinza1.transform.localPosition = (new Vector3(2,-0.5f,0));
            pinza2.transform.localPosition =(new Vector3(2,0.5f,0));
        }


    }
    public void SetAnguloArticulacionHorizontal(float anguloHorizontal)
    {
        if(anguloHorizontal > ANGULO_MAXIMOH)
            anguloHorizontal = ANGULO_MAXIMOH;
        if(anguloHorizontal < ANGULO_MINIMOH)
            anguloHorizontal = ANGULO_MINIMOH;

       
        leftRight = anguloHorizontal;
       
    }

    public void SetAnguloArticulacionVertical(float anguloVertical)
    {
         if(anguloVertical > ANGULO_MAXIMOV)
            anguloVertical = ANGULO_MAXIMOV;
        if(anguloVertical < ANGULO_MINIMOV)
            anguloVertical = ANGULO_MINIMOV;
        upDown = anguloVertical;
    }

    public void HorizontalArticulacion(bool horizontal)
    {
        float diferencia = Time.deltaTime * velocidad;
        if(!horizontal)
        {
            diferencia = -diferencia;
        }
        SetAnguloArticulacionHorizontal(leftRight + diferencia);
    }
    public void VerticalArticulacion(bool vertical)
    {
        float diferencia = Time.deltaTime * velocidad;
        if(!vertical)
        {
            diferencia = -diferencia;
        }
        SetAnguloArticulacionVertical( upDown + diferencia);
    }

    public void UsePinzasBool(bool use)
    {
        usePinzas = use;
    }
}
