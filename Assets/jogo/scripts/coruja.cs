using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class coruja : MonoBehaviour
{
    // Start is called before the first frame update
    public bool sentado;
    private Animator anim;
    public bool sentar;
    public float speed;
    public Rigidbody rig;
    public float rot;
    private float rotSpeed;
    private Vector3 moveDirection;
    public bool dados;

    public Vector3 pos;

    public dice codigododice;
    public cancela codigodacancela;
   
    public int numerocadeira;

    public bool isGrounded;
    public bool cancela;

 

    public bool olevantar;



    public int tele;
    public bool astro;

    public GameObject astronauta;
    public GameObject ape;

    public GameObject cam;



    //cena do carro
    public bool carro;
    public bool nocarro;
    public GameObject carroobj;
    public Vector3 posnocarro;
    public carmove scriptdocarro;
    public GameObject cameradocarro;
    public GameObject cameradopersonagem;
    public CapsuleCollider colliderdopersonagem;

    //cena Casino
    public float ajusterot;
    public int direcao;


    public bool pausa;

    public GameObject canvas;
    public GameObject canvasmenu;





    void Start()
    {
        rotSpeed = 100;
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
        anim.Play("corujaparada");
    }

    // Update is called once per frame
    void Update()

    {
        if(pausa){
            canvas.SetActive(false);
            canvasmenu.SetActive(true);
            Time.timeScale =0;
       }
       else{
            canvas.SetActive(true);
            canvasmenu.SetActive(false);
            Time.timeScale =1;
       }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            botaoa(); 
        }
        if(nocarro)
        {
            anim.Play("corujasentando");
            scriptdocarro.enabled = true;
            cameradocarro.SetActive(true);
            cameradopersonagem.SetActive(false);
            colliderdopersonagem.enabled = false;
            transform.localPosition = new Vector3(-0.34f,-0.20f,-0.14f);
            transform.localRotation =  Quaternion.Euler(0, 0, 0);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                
                botaob();
            }

          
        }
        if(carro && !nocarro){
            if(Input.GetKeyDown(KeyCode.Space)) {
                botaob();
            }
        }

        if(cancela)
        {
            if(Input.GetKeyDown(KeyCode.Space)){
                botaob();
            }
        }
         if(dados)
         {
            if(Input.GetKeyDown(KeyCode.Space))
            { 
                botaob();
                
            }

            if(Input.GetKeyDown(KeyCode.Mouse0))
            { 
                botaoy();
            }
         }    


       // 
        if(sentado)
        {
            if(numerocadeira==0){
                transform.position = new Vector3(pos.x+0.16f,pos.y-0.58f,pos.z+0.1f);
               // transform.localRotation = Quaternion.Euler(0, -180.48f+ajusterot, 0);
                transform.eulerAngles = new Vector3(0, -180.47f, 0);
            }
            if(numerocadeira==1){
                transform.position = new Vector3(pos.x,pos.y-0.58f,pos.z-0.1f);
                //transform.localRotation = Quaternion.Euler(0, -90f+ajusterot, 0);
                transform.eulerAngles = new Vector3(0, -90f, 0);
            }
             if(numerocadeira==2){
                transform.position = new Vector3(pos.x+0f,pos.y-0.58f,pos.z+0.1f);
                //transform.localRotation = Quaternion.Euler(0, 90f+ajusterot, 0);
                 transform.eulerAngles = new Vector3(0, 90f, 0);
            }
             if(numerocadeira==3){
                transform.position = new Vector3(pos.x-0.16f,pos.y-0.58f,pos.z+0.17f);
                //transform.localRotation = Quaternion.Euler(0, 0+ajusterot, 0);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            if(numerocadeira==4){
                transform.position = new Vector3(pos.x+10.0f,pos.y+0.8f,pos.z+14.4f);
                //transform.localRotation = Quaternion.Euler(0, 90f+ajusterot, 0);
                transform.eulerAngles = new Vector3(0, 90f, 0);
            }
             if(numerocadeira==5){
                transform.position = new Vector3(pos.x-14.4f,pos.y+0.8f,pos.z+10f);
                //transform.localRotation = Quaternion.Euler(0, 0+ajusterot, 0);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }

            //cadeiras da academia
            if(numerocadeira==6){
                transform.position = new Vector3(pos.x+0.6f,pos.y-0.4f,pos.z+1.0f);
               transform.eulerAngles = new Vector3(0, 103.1f-90, 0);
            }
            if(numerocadeira==7){
                transform.position = new Vector3(pos.x+0.91f,pos.y-0.4f,pos.z-0.7f);
                transform.eulerAngles = new Vector3(0, 195.28f-90, 0);
            }
            if(numerocadeira==8){
                 transform.position = new Vector3(pos.x+0.91f,pos.y-0.4f,pos.z-0.41f);
                transform.eulerAngles = new Vector3(0, 200f-90, 0);
            }
             if(numerocadeira==9){
                 transform.position = new Vector3(pos.x-0.91f,pos.y-0.4f,pos.z+0.5f);
                transform.eulerAngles = new Vector3(0, 17.34f-90, 0);
            }
            if(numerocadeira==10){
                transform.position = new Vector3(pos.x-0.91f,pos.y-0.4f,pos.z+0.41f);
                transform.eulerAngles = new Vector3(0, 9f-90, 0);
            }
            if(numerocadeira==11){
                transform.position = new Vector3(pos.x-0.7f,pos.y-0.4f,pos.z-0.8f);
                transform.eulerAngles = new Vector3(0, 294.43f-90, 0);
            }
            if(numerocadeira==12){
               transform.position = new Vector3(pos.x+0.4f,pos.y-0.4f,pos.z-0.8f);
                transform.eulerAngles = new Vector3(0, 230.90f-90, 0);
            }
            if(numerocadeira==13){
                transform.position = new Vector3(pos.x-0.0f,pos.y-0.1f,pos.z+0.0f);
                transform.eulerAngles = new Vector3(0, -3.22f-90, 0);
            }
            if(numerocadeira==14){
                transform.position = new Vector3(pos.x+0.0f,pos.y-0.1f,pos.z-0.0f);
                transform.eulerAngles = new Vector3(0, 173.63f-90, 0);
            }







            if(Input.GetKeyDown(KeyCode.Space))
            {
               
               botaob();
                    
            }
        }
        if(sentar){
             if(Input.GetKey(KeyCode.Space))
            {
                botaob();
                  
            }    
        }
        
       
       
       
    }
    private void FixedUpdate() {
        Move();
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            botaoa();
        }
       
    }
   
    void Move()
    {
        if(direcao==0){}
        if(direcao==1){transform.Translate(0,0,speed);}
        if(direcao==2){rot +=1 * rotSpeed * Time.deltaTime;transform.eulerAngles=  new Vector3(0,rot,0);}
        if(direcao==3){rot +=-1 * rotSpeed * Time.deltaTime;transform.eulerAngles=  new Vector3(0,rot,0);}
        if(isGrounded)
        {

            if(Input.GetKey(KeyCode.UpArrow)&&!sentado&&!nocarro)
            {
                    andarprafrente(); 
            }

             if(Input.GetKeyUp(KeyCode.UpArrow)&&!sentado&&!nocarro)
            {
                Fparar();

            }
        }
        if(!sentado&&!nocarro)
        {
            transform.eulerAngles=  new Vector3(0,rot,0);
             if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.LeftArrow))
            {
                virar(Input.GetAxis("Horizontal"));
            }

             if(Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.LeftArrow))
            {
                Fparar();

            }
            
        }
    }
    public void andarprafrente(){
        anim.Play("curujaandando");
        transform.Translate(0,0,speed);
        direcao=1;
    }
    public void Fparar(){
        rig.velocity = new Vector3(0, 0, 0);
        anim.Play("corujaparada");
        direcao=0;
    }
    public void virar(float a){
         anim.Play("curujaandando");
         if(a>0){direcao=2;}
        if(a<0){direcao=3;}
    }
     public void botaoa(){
        if(isGrounded)
        {
            isGrounded=false; 
            rig.AddForce(0,3000,0);
            StartCoroutine(pular());
        }

    }
    public void botaob(){
         if(sentar&&!olevantar){
            StartCoroutine(ativadordesentado());
         }
        if(sentado)
        {
            StartCoroutine(levantar());
            olevantar=true;
        }
         if(dados){
            if(codigododice.aberto){codigododice.fechar();}
            else{codigododice.abrir();}
         }
         if(cancela){
            codigodacancela.aberto=!codigodacancela.aberto;
         }
         
         if(nocarro){
            StartCoroutine(levantardocarro());
         }
         if(carro && !nocarro){
             nocarro = true;
         }
    }
    public void botaoy(){
        if(tele == 1){SceneManager.LoadScene("casino");}
        if(tele == 2){SceneManager.LoadScene("car chase");}
        if(tele == 3){SceneManager.LoadScene("space");}
        if(tele == 4){SceneManager.LoadScene("academia");}
        if(tele == 5){SceneManager.LoadScene("snupdog");}
        if(tele == 6){SceneManager.LoadScene("video1");}
        if(tele == 7){SceneManager.LoadScene("danca");}
        if(tele == 8){SceneManager.LoadScene("car");}
        if(astro){ape.SetActive(false);astronauta.SetActive(true);}
        if(dados){
            codigododice.sortearnumero();
        }
    }
    public void pausar(){
        pausa=!pausa;
    }
    public void menu(){
        SceneManager.LoadScene("casino");
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="dice"){
            dados=true;
            codigododice =  other.gameObject.GetComponent<dice>();
        }
         if(other.gameObject.tag=="cancela"){
            cancela = true;
            
        }
        if(other.gameObject.tag=="cadeira"){
            sentar = true;
            if(!sentado)
            {
                pos= new Vector3
                (other.gameObject.transform.position.x,
                other.gameObject.transform.position.y,
                other.gameObject.transform.position.z);

               numerocadeira = other.gameObject.GetComponent<posicaodesentar>().numero;
            }
           
            //23,88/0,61/1,77
        }




         if(other.gameObject.tag=="tele1"){
            tele = 1;
        }
        if(other.gameObject.tag=="tele2"){
            tele = 2;
        }
        if(other.gameObject.tag=="tele3"){
            tele = 3;
        }
        if(other.gameObject.tag=="tele4"){
            tele = 4;
        }
        if(other.gameObject.tag=="tele5"){
            tele = 5;
        }
        if(other.gameObject.tag=="tele6"){
            tele = 6;
        }
         if(other.gameObject.tag=="tele7"){
            tele = 7;
        }
        if(other.gameObject.tag=="tele8"){
            tele = 8;
        }


        if(other.gameObject.tag=="astro"){
            astro = true;
        }
        if(other.gameObject.tag=="carro"){
            carro = true;
        }
       
        
    }
  
    private void OnTriggerStay(Collider other) {
       
        if(other.gameObject.tag=="cadeira"){
            sentar = true;
            
        }
        if(other.gameObject.tag=="cancela"){
            cancela = true;
            codigodacancela =  other.gameObject.GetComponent<cancela>();
            
        }
        if(other.gameObject.tag=="dice"){
            dados=true;
             codigododice =  other.gameObject.GetComponent<dice>();
        }

        if(other.gameObject.tag=="tele1"){
            tele = 1;
        }
        if(other.gameObject.tag=="tele2"){
            tele = 2;
        }
        if(other.gameObject.tag=="tele3"){
            tele = 3;
        }
        if(other.gameObject.tag=="tele4"){
            tele = 4;
        }
        if(other.gameObject.tag=="tele5"){
            tele = 5;
        }
        if(other.gameObject.tag=="tele6"){
            tele = 6;
        }
         if(other.gameObject.tag=="tele7"){
            tele = 7;
        }
        if(other.gameObject.tag=="tele8"){
            tele = 8;
        }


        if(other.gameObject.tag=="astro"){
            astro = true;
        }
        if(other.gameObject.tag=="carro"){
            carro = true;
        }


        
    }
     private void OnTriggerExit(Collider other) {
       
        if(other.gameObject.tag=="cadeira"){
            sentar = false;
            
        }
        if(other.gameObject.tag=="cancela"){
            cancela = false;
            
        }
        if(other.gameObject.tag=="dice"){
            dados=false;
            cam.transform.localPosition = new Vector3(-0.74f,4.77f,-6.03f);
            cam.transform.localRotation = Quaternion.Euler(9.48f, 3.65f, 3.18f);
        }


        if(other.gameObject.tag=="tele1"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele2"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele3"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele4"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele5"){
            tele = 0;
        }
        if(other.gameObject.tag=="tele6"){
            tele = 0;
        }
         if(other.gameObject.tag=="tele7"){
            tele = 0;
        }
         if(other.gameObject.tag=="tele8"){
            tele = 0;
        }
        

        if(other.gameObject.tag=="astro"){
            astro = false;
        }
        if(other.gameObject.tag=="carro"){
            carro = false;
        }
        
    }
     private void OnCollisionEnter(Collision other) {
       rig.velocity = new Vector3(0, 0, 0);
        if(other.gameObject.tag=="cadeira"){
            rig.velocity = new Vector3(0, 0, 0);
        }
        if(other.gameObject.tag=="dice"){
             rig.velocity = new Vector3(0, 0, 0);
        }
       
        
    }



     private void OnCollisionExit(Collision other) {
       rig.velocity = new Vector3(0, 0, 0);
        if(other.gameObject.tag=="cadeira"){
            rig.velocity = new Vector3(0, 0, 0);
        }
        if(other.gameObject.tag=="dice"){
             rig.velocity = new Vector3(0, 0, 0);
            
        }


   
       
        
    }
     IEnumerator pular() 
     { 
         yield return new WaitForSeconds(0.7f);
         isGrounded=true;
         
     }
    IEnumerator levantardocarro() 
     {
            yield return new WaitForSeconds(0.01f);
            nocarro = false;
             transform.localPosition = new Vector3(-0.34f,+2.20f,-4f);
            anim.Play("corujaparada");
            scriptdocarro.rig.velocity = new Vector3(0, 0, 0);
            scriptdocarro.enabled = false;
            cameradocarro.SetActive(false);
            cameradopersonagem.SetActive(true);
            colliderdopersonagem.enabled = true;
             carro = false;
     }
    IEnumerator ativadordesentado() {
    
    
              

                yield return new WaitForSeconds(0.01f);
                  sentado=true;
       
                 anim.Play("corujasentando");
                 

                 //cam
                 cam.transform.localPosition = new Vector3(0.12f,4.31f,6.06f);
                cam.transform.localRotation = Quaternion.Euler(15, 180, 0);
  
    }

    IEnumerator levantar() {
      
               
               
    yield return new WaitForSeconds(0.1f);
                //posição ao levantar
                if(numerocadeira==0){
                     transform.position = new Vector3(pos.x-1.38f,pos.y-0.58f,pos.z+2.2f);
                }
                if(numerocadeira==1){
                     transform.position = new Vector3(pos.x+2.3f,pos.y-0.58f,pos.z+1.43f);
                }
                 if(numerocadeira==2){
                      transform.position = new Vector3(pos.x-2.3f,pos.y-0.58f,pos.z-1.43f);
                }
                 if(numerocadeira==3){
                     transform.position = new Vector3(pos.x+1.38f,pos.y-0.58f,pos.z-1.43f);
                }
                anim.Play("corujaparada");
                sentar = false;
                 sentado=false;

                 //cam
                 cam.transform.localPosition = new Vector3(-0.74f,4.77f,-6.03f);
                cam.transform.localRotation = Quaternion.Euler(9.48f, 3.65f, 3.18f);
                olevantar=false;
  
    }












}
