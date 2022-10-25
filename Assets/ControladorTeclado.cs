using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTeclado : MonoBehaviour
{
    public MoveR robot;
    float anguloHorizontal;
    float anguloVertical;

    public float velocidad = 50f;
    // Start is called before the first frame update
    void Start()
    {
        anguloHorizontal = 0;
        anguloVertical = 0;
        robot.SetAnguloArticulacionHorizontal(anguloHorizontal);
        robot.SetAnguloArticulacionVertical(anguloVertical);
    }

    // Update is called once per frame
    void Update()
    {
        float hh = Input.GetAxis("Horizontal");
        float vv = Input.GetAxis("Vertical");
        anguloHorizontal = anguloHorizontal  + Time.deltaTime * hh *velocidad;
        anguloVertical = anguloVertical  + Time.deltaTime * vv *velocidad;
        //robot.SetAnguloArticulacion(anguloVertical, anguloHorizontal);
        if(hh > 0)
        {
            robot.HorizontalArticulacion(true);
        }else if(hh < 0)
        {
            robot.HorizontalArticulacion(false);
        }

        if(vv > 0)
        {
            robot.VerticalArticulacion(true);
        }else if(vv < 0)
        {
            robot.VerticalArticulacion(false);
        }

        if(Input.GetKey(KeyCode.Space)){
          robot.UsePinzasBool(true);
        }
        else
        robot.UsePinzasBool(false);
    
    }
}
