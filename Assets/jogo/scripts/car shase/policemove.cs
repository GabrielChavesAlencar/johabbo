using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policemove : MonoBehaviour
{
    public float MotorForce, SteerForce,BrakeForce;
    public WheelCollider Rfrentedireita,Rfrenteesquerda,Rtrasdireita,Rtrasesquerda;
    public Transform transfrentedireita,transfrenteesquerda,transtrasdireita,transtrasesquerda;
    // Start is called before the first frame update
 

    public Vector3 pos;
    public Quaternion rot;


    public float Maxspeed;

    public float speed;

    public Rigidbody rig;
   void Start()
    {
        rig = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
         speed = rig.velocity.sqrMagnitude;

         if(speed < Maxspeed)
         {
        Rtrasdireita.motorTorque = MotorForce;
        Rtrasesquerda.motorTorque = MotorForce;
        }
        else
         {
             Rtrasdireita.motorTorque = 0;
            Rtrasesquerda.motorTorque = 0;
         }

       // 

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
    }
 
     private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="virar"){
        Rfrentedireita.steerAngle = SteerForce;
        Rfrenteesquerda.steerAngle = SteerForce;

       // rig.AddForce(0,0,1000000);

        }
    }
     private void OnCollisionEnter(Collision other) 
     {
         if(other.gameObject.tag=="pular")
         {
             rig.velocity = new Vector3(10, 0, 0);
             rig.AddForce(300000,400000,0);
              
         }
     }
}
