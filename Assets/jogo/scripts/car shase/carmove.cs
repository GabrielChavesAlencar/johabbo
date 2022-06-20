using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class carmove : MonoBehaviour
{
    public float MotorForce, SteerForce,BrakeForce;
    public WheelCollider Rfrentedireita,Rfrenteesquerda,Rtrasdireita,Rtrasesquerda;
    public Transform transfrentedireita,transfrenteesquerda,transtrasdireita,transtrasesquerda;
    // Start is called before the first frame update
 

    public Vector3 pos;
    public Quaternion rot;
    public Rigidbody rig;


    public float h;
    public float Maxspeed;

    public float speed;

    public float v;

    public bool andando;

    public int mult;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = rig.velocity.sqrMagnitude;

        
        if(speed < Maxspeed){
             if(Input.GetAxis("Vertical")!=0){
                v  = Input.GetAxis("Vertical") * MotorForce;
            }
            if(andando){
                v  = mult * MotorForce;
            }
            Rtrasdireita.motorTorque = v;
            Rtrasesquerda.motorTorque = v;
         }else
         {
            Rtrasdireita.motorTorque = 0;
            Rtrasesquerda.motorTorque = 0;
         }
        
        if(Input.GetAxis("Horizontal")!=0){
            h  = Input.GetAxis("Horizontal") * SteerForce;
        }

       

        Rfrentedireita.steerAngle = h;
        Rfrenteesquerda.steerAngle = h;

        //rotação roda da frente direita
        Rfrentedireita.GetWorldPose(out pos,out rot);
        transfrentedireita.position = pos;
        transfrentedireita.rotation = rot;

        //rotação roda da frente esquerda
        Rfrenteesquerda.GetWorldPose(out pos,out rot);
        transfrenteesquerda.position = pos;
        transfrenteesquerda.rotation = rot;

        //rotação roda da tras direita
        Rtrasdireita.GetWorldPose(out pos,out rot);
        transtrasdireita.position = pos;
        transtrasdireita.rotation = rot;

        //rotação roda da tras esquerda
        Rtrasesquerda.GetWorldPose(out pos,out rot);
        transtrasesquerda.position = pos;
        transtrasesquerda.rotation = rot;






        
        if(Input.GetAxis("Vertical") == 0 && !andando)
        {
            Rtrasdireita.brakeTorque = BrakeForce;
            Rtrasesquerda.brakeTorque = BrakeForce;
        }
        else
        {
            Rtrasdireita.brakeTorque = 0;
            Rtrasesquerda.brakeTorque = 0;
        }



    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="virar"){
            rig.velocity = new Vector3(3, 0, 0);
        }
    }
    public void virar(int valor){
        h  = valor * SteerForce;
    }

    public void andar(int valor){
        andando=true;
        mult = valor;
    }
    public void soltar(){
        andando=false;
    }
}
